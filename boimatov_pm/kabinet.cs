using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boimatov_pm
{
    public partial class kabinet : Form
    {
        private database db = new database();

        public kabinet()
        {
            InitializeComponent();
            LoadClientApplications();
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["status"].Index && e.Value != null)
            {
                switch (e.Value.ToString())
                {
                    case "1":
                        e.Value = "ПОДАНО";
                        break;
                    case "2":
                        e.Value = "ГОТОВО";
                        break;
                    case "3":
                        e.Value = "ОТКЛОНЕНО";
                        break;
                    case "4":
                        e.Value = "В ДОРАБОТКУ";
                        break;
                }
                e.FormattingApplied = true;
            }
        }

        private void LoadClientApplications()
        {
            if (DataBank.id_pols == 0) 
            {
                MessageBox.Show("ID клиента не определен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT id, napr_id, client_id, bal_att, date_pod, document_pdf, status, coments, worker_id FROM spo WHERE client_id = @client_id";
            DataTable dataTable = new DataTable();

            db.OpenConnection();
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, db.getConnection()))
                {
                    command.Parameters.AddWithValue("@client_id", DataBank.id_pols);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns["id"].HeaderText = "ID Записи";
                dataGridView1.Columns["napr_id"].HeaderText = "ID Направления";
                dataGridView1.Columns["client_id"].HeaderText = "ID Клиента";
                dataGridView1.Columns["bal_att"].HeaderText = "Балл Аттестата";
                dataGridView1.Columns["date_pod"].HeaderText = "Дата Подачи";
                dataGridView1.Columns["coments"].HeaderText = "Комментарии";
                dataGridView1.Columns["worker_id"].HeaderText = "ID Сотрудника";

                dataGridView1.Columns["status"].HeaderText = "Статус";
                dataGridView1.CellFormatting += dataGridView1_CellFormatting_1;

                if (dataGridView1.Columns.Contains("document_pdf"))
                {
                    dataGridView1.Columns["document_pdf"].Visible = false;
                }
             
                if (dataGridView1.Columns.Contains("id"))
                {
                    dataGridView1.Columns["id"].Visible = false;
                }
                if (dataGridView1.Columns.Contains("client_id"))
                {
                    dataGridView1.Columns["client_id"].Visible = false;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при загрузке заявок: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private byte[] LoadPdfDocumentById(int applicationId)
        {
            byte[] pdfData = null;

            db.OpenConnection();
            try
            {
                string query = "SELECT document_pdf FROM spo WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, db.getConnection()))
                {
                    command.Parameters.AddWithValue("@id", applicationId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(reader.GetOrdinal("document_pdf")))
                        {
                            pdfData = (byte[])reader["document_pdf"];
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при загрузке PDF: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
            return pdfData;
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void new_but_Click(object sender, EventArgs e)
        {
            viborUrovna vb = new viborUrovna();
            this.Hide();
            vb.ShowDialog();
            this.Show();
            this.Close();
        }

        private void viewDocumentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

              
                if (dataGridView1.Columns.Contains("id"))
                {
              
                    if (selectedRow.Cells["id"].Value != null)
                    {
                        int applicationId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                        byte[] pdfBytes = LoadPdfDocumentById(applicationId);

                        if (pdfBytes != null && pdfBytes.Length > 0)
                        {
                            try
                            {
                                string tempFilePath = Path.Combine(Path.GetTempPath(), $"document_{applicationId}.pdf");
                                File.WriteAllBytes(tempFilePath, pdfBytes);
                                System.Diagnostics.Process.Start(tempFilePath);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Ошибка при открытии PDF: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("PDF-документ не найден или пуст для выбранной заявки.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выбранная строка не содержит ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Столбец 'id' не найден в DataGridView.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку в таблице для просмотра документа.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем первую выделенную строку
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Проверяем, существует ли столбец "id" и что ячейка не пустая
                if (dataGridView1.Columns.Contains("id") && selectedRow.Cells["id"].Value != null)
                {
                    // Получаем значение id и записываем его в textBox1
                    textBox1.Text = selectedRow.Cells["id"].Value.ToString();
                }
                else
                {
                    // Если столбец "id" отсутствует или значение пустое, очищаем textBox1
                    textBox1.Text = string.Empty;
                }
            }
            else
            {
                // Если ни одна строка не выбрана, очищаем textBox1
                textBox1.Text = string.Empty;
            }
        }

        private void delete_but_Click(object sender, EventArgs e)
        {

        }
    }
}

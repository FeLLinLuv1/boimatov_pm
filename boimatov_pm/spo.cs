using Npgsql;
using NpgsqlTypes;
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
    public partial class spo : Form
    {
        private database db = new database();
        private byte[] selectedPdfBytes = null;

        public spo()
        {
            InitializeComponent();
            FillNapravleniyaComboBox();
        }

        private void ready_but_Click(object sender, EventArgs e)
        {
            var napr = napravleniyaComboBox.Text;
            decimal bal = 0;
            if (!decimal.TryParse(balAtt_text.Text, out bal))
            {
                MessageBox.Show("Пожалуйста, введите корректный балл аттестата.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime dt = DateTime.Now;

            if (selectedPdfBytes == null || selectedPdfBytes.Length == 0)
            {
                MessageBox.Show("Пожалуйста, выберите PDF-файл перед подачей заявления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int napravleniyaId = db.GetNapravleniyaIdByName(napr);
            if (napravleniyaId == -1)
            {
                MessageBox.Show($"Не удалось получить ID для направления '{napr}'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string insertQuery = "INSERT INTO spo (napr_id, client_id, bal_att, date_pod, document_pdf, status, coments) " +
                                 "VALUES (@napr_id, @client_id, @bal_att, @date_pod, @document_pdf, @status, @coments)";

            db.OpenConnection();
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, db.getConnection()))
                {
                    command.Parameters.AddWithValue("@napr_id", napravleniyaId);
                    command.Parameters.AddWithValue("@client_id", DataBank.id_pols);
                    command.Parameters.AddWithValue("@bal_att", bal);
                    command.Parameters.AddWithValue("@date_pod", dt);
                    command.Parameters.AddWithValue("@document_pdf", NpgsqlDbType.Bytea, selectedPdfBytes.Length).Value = selectedPdfBytes;
                    command.Parameters.AddWithValue("@status", 1);
                    command.Parameters.AddWithValue("@coments", " "); 

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Заявление и документ успешно поданы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                        selectedPdfBytes = null;
                      
                    }
                    else
                    {
                        MessageBox.Show("Не удалось подать заявление.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при работе с базой данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void FillNapravleniyaComboBox()
        {
            string query = "SELECT name FROM napravlen WHERE uroven_id = 1";
            DataTable dataTable = new DataTable();

            db.OpenConnection();
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, db.getConnection()))
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                napravleniyaComboBox.Items.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    napravleniyaComboBox.Items.Add(row["name"].ToString());
                }

                if (napravleniyaComboBox.Items.Count > 0)
                {
                    napravleniyaComboBox.SelectedIndex = 0;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при получении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            viborUrovna vb = new viborUrovna();
            this.Hide();
            vb.ShowDialog();
            this.Show();
            this.Close();
        }

        private void pricrepit_but_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите PDF файл";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    selectedPdfBytes = File.ReadAllBytes(selectedFilePath);
                    txtFilePath.Text = Path.GetFileName(selectedFilePath);
                    MessageBox.Show($"Файл успешно выбран и готов к отправке.", "Файл выбран", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    selectedPdfBytes = null;
                    txtFilePath.Text = string.Empty;

                }
            }
            else
            {
                MessageBox.Show("Выбор файла отменен.", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                selectedPdfBytes = null;
                txtFilePath.Text = string.Empty;    

            }
        }
    }
}

using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace boimatov_pm
{
    public partial class obrabotka : Form
    {
        private database db = new database();
        private DataTable spoDataTable;
        private int selectedApplicationIdForComment = -1;

        public obrabotka()
        {
            InitializeComponent();
            LoadAllSpoApplications();
        }

        private void LoadAllSpoApplications()
        {
            string query = "SELECT id, napr_id, client_id, bal_att, date_pod, status, coments, worker_id FROM spo"; // Исключаем столбец document_pdf
            spoDataTable = new DataTable();

            db.OpenConnection();
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, db.getConnection()))
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    adapter.Fill(spoDataTable);
                }

                spoDataGridView.DataSource = spoDataTable;

                // Настройка заголовков столбцов
                spoDataGridView.Columns["id"].HeaderText = "ID Записи";
                spoDataGridView.Columns["napr_id"].HeaderText = "ID Направления";
                spoDataGridView.Columns["client_id"].HeaderText = "ID Клиента";
                spoDataGridView.Columns["bal_att"].HeaderText = "Балл Аттестата";
                spoDataGridView.Columns["date_pod"].HeaderText = "Дата Подачи";
                spoDataGridView.Columns["status"].HeaderText = "Статус";
                spoDataGridView.Columns["coments"].HeaderText = "Комментарии";
                spoDataGridView.Columns["worker_id"].HeaderText = "ID Сотрудника";

                // Форматирование столбца "status" (если необходимо)
                if (spoDataGridView.Columns.Contains("status"))
                {
                    spoDataGridView.CellFormatting += spoDataGridView_CellFormatting;
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

        private void exit_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void slughebnoe_but_Click(object sender, EventArgs e)
        {
            slughebnoe sl = new slughebnoe();
            this.Hide();
            sl.ShowDialog();
            this.Show();
            this.Close();
        }

        private void filterDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = filterDatePicker.Value.Date;
            spoDataTable.DefaultView.RowFilter = $"date_pod = '{selectedDate:yyyy-MM-dd}'";
        }

        private void vseZayavki_but_Click(object sender, EventArgs e)
        {
            spoDataTable.DefaultView.RowFilter = string.Empty;
        }

        private void spoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Обращаемся к столбцу "status" по имени
            if (spoDataGridView.Columns["status"] != null && e.ColumnIndex == spoDataGridView.Columns["status"].Index && e.Value != null)
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
        private int currentUserId = DataBank.id_sotr;
        private void SetApplicationStatus(int newStatus)
        {
            if (spoDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = spoDataGridView.SelectedRows[0];

                // Проверяем, существует ли столбец "id" и что значение ячейки не null
                if (spoDataGridView.Columns.Contains("id") && selectedRow.Cells["id"].Value != null)
                {
                    int applicationId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    db.OpenConnection();
                    try
                    {
                        string updateQuery = "UPDATE spo SET status = @status, worker_id = @worker_id WHERE id = @id";
                        using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, db.getConnection()))
                        {
                            command.Parameters.AddWithValue("@status", newStatus);
                            command.Parameters.AddWithValue("@worker_id", currentUserId); // Записываем ID пользователя
                            command.Parameters.AddWithValue("@id", applicationId);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Статус заявки с ID {applicationId} успешно обновлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadAllSpoApplications(); // Обновляем DataGridView
                            }
                            else
                            {
                                MessageBox.Show($"Заявка с ID {applicationId} не найдена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show($"Ошибка при обновлении статуса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Выбранная строка не содержит ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку в таблице.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ready_but_Click(object sender, EventArgs e)
        {
            SetApplicationStatus(2);
        }

        private void otklonit_but_Click(object sender, EventArgs e)
        {
            SetApplicationStatus(3);
        }

        private void dorabotka_but_Click(object sender, EventArgs e)
        {
            SetApplicationStatus(4);
        }

        private void spoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обращаемся к столбцу "coments" по имени
            if (e.RowIndex >= 0 && spoDataGridView.Columns["coments"] != null && e.ColumnIndex == spoDataGridView.Columns["coments"].Index)
            {

                if (spoDataGridView.Rows[e.RowIndex].Cells["coments"].Value != null)
                {
                    commentsTextBox.Text = spoDataGridView.Rows[e.RowIndex].Cells["coments"].Value.ToString();
                }
                else
                {
                    commentsTextBox.Text = string.Empty; // Очищаем TextBox, если комментарий пустой
                }

                // Сохраняем ID выбранной заявки для последующего обновления
                if (spoDataGridView.Columns.Contains("id") && spoDataGridView.Rows[e.RowIndex].Cells["id"].Value != null)
                {
                    selectedApplicationIdForComment = Convert.ToInt32(spoDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                }
                else
                {
                    selectedApplicationIdForComment = -1; // Сбрасываем ID, если не удалось получить
                }
            }
            else
            {
                // Если кликнули не на столбец "coments", очищаем TextBox и сбрасываем ID
                commentsTextBox.Text = string.Empty;
                selectedApplicationIdForComment = -1;
            }
        }

        private void UpdateCommentInDatabase(int applicationId, string comment)
        {
            db.OpenConnection();
            try
            {
                string updateQuery = "UPDATE spo SET coments = @coments WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, db.getConnection()))
                {
                    command.Parameters.AddWithValue("@coments", comment);
                    command.Parameters.AddWithValue("@id", applicationId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Optionally, provide feedback to the user
                        // MessageBox.Show($"Комментарий к заявке с ID {applicationId} обновлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllSpoApplications(); // Обновляем DataGridView
                    }
                    else
                    {
                        MessageBox.Show($"Заявка с ID {applicationId} не найдена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при обновлении комментария: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedApplicationIdForComment != -1)
            {
                string newComment = commentsTextBox.Text;
                UpdateCommentInDatabase(selectedApplicationIdForComment, newComment);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку и ее комментарий для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boimatov_pm
{
    public partial class slughebnoe : Form
    {
        private database db = new database();
        private DataTable napravlenDataTable;
        private NpgsqlDataAdapter napravlenDataAdapter;
        private DataTable urovenDataTable;
        private NpgsqlDataAdapter urovenDataAdapter;

        public slughebnoe()
        {
            InitializeComponent();
            LoadNapravlenData();
            LoadUrovenData();
        }

        private void addNapravlenButton_Click(object sender, EventArgs e)
        {
            DataRow newRow = napravlenDataTable.NewRow();
            napravlenDataTable.Rows.Add(newRow);
        }
        private void LoadUrovenData()
        {
            string query = "SELECT id, title FROM uroven"; // Включаем столбец 'id'
            urovenDataTable = new DataTable();
            urovenDataAdapter = new NpgsqlDataAdapter(query, db.getConnection());

            db.OpenConnection();
            try
            {
                urovenDataAdapter.Fill(urovenDataTable);
                urovenDataGridView.DataSource = urovenDataTable;

                urovenDataGridView.Columns["id"].Visible = false; // Скрываем столбец 'id' от пользователя (если нужно)
                urovenDataGridView.Columns["title"].HeaderText = "Название уровня";
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при загрузке уровней: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void LoadNapravlenData()
        {
            string query = "SELECT id, name, places, uroven_id FROM napravlen"; // Включаем столбец 'id'
            napravlenDataTable = new DataTable();
            napravlenDataAdapter = new NpgsqlDataAdapter(query, db.getConnection()); // Инициализируем DataAdapter

            db.OpenConnection();
            try
            {
                napravlenDataAdapter.Fill(napravlenDataTable);
                napravlenDataGridView.DataSource = napravlenDataTable;

                napravlenDataGridView.Columns["id"].Visible = false; // Скрываем столбец 'id' от пользователя (если нужно)
                napravlenDataGridView.Columns["name"].HeaderText = "Название направления";
                napravlenDataGridView.Columns["places"].HeaderText = "Количество мест";
                napravlenDataGridView.Columns["uroven_id"].HeaderText = "ID Уровня";
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при загрузке направлений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }
        private void slughebnoe_Load(object sender, EventArgs e)
        {

        }

        private void readyNapr_but_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            try
            {
                using (NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(napravlenDataAdapter))
                {
                    napravlenDataAdapter.Update(napravlenDataTable);
                    MessageBox.Show("Изменения сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNapravlenData(); // Обновляем DataGridView после сохранения
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void readyUroven_but_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            try
            {
                using (NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(urovenDataAdapter))
                {
                    urovenDataAdapter.Update(urovenDataTable);
                    MessageBox.Show("Изменения сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUrovenData(); // Обновляем DataGridView после сохранения
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow newRow = urovenDataTable.NewRow();
            urovenDataTable.Rows.Add(newRow);
        }
    }
}

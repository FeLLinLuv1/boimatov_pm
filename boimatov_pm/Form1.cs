using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace boimatov_pm
{
    public partial class Form1 : Form
    {
        private database db = new database();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void vhod_but_Click(object sender, EventArgs e)
        {
          AuthorizeUser();
        }

        private void AuthorizeUser()
        {
            var login = login_text.Text;
            var password = password_text.Text;
            DataBank.Login_pols = login;

            if (string.IsNullOrEmpty(login)|| string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            string query = "SELECT COUNT(*) FROM clients WHERE login = @login AND password = @password";
            db.OpenConnection();
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, db.getConnection()))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);

                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    if (userCount > 0)
                    {

                        database db = new database();
                        int clientId = db.GetClientIdByLogin(login);

                        if (clientId != -1)
                        {
                            DataBank.id_pols = clientId;
                        }
                        else
                        {
                            MessageBox.Show("Не удалось получить ID клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MessageBox.Show("Авторизация прошла успешно");
                        kabinet kab = new kabinet();
                        this.Hide();
                        kab.ShowDialog();
                        this.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка авторизации");
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(" Ошибка подключения" + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void register_but_Click(object sender, EventArgs e)
        {
            register reg = new register();
            this.Hide();
            reg.ShowDialog();
            this.Show();
            this.Close();
        }

        private void worker_but_Click(object sender, EventArgs e)
        {
            sotr st = new sotr();
            this.Hide();
            st.ShowDialog();
            this.Show();
            this.Close();

                
        }
    }
}

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
    public partial class sotr : Form
    {
        private database db = new database();

        public sotr()
        {
            InitializeComponent();
        }

        private void vhod_but_Click(object sender, EventArgs e)
        {
            AuthorizateSotr();
        }

        private void AuthorizateSotr()
        {
            var login = login_text.Text;
            var password = password_text.Text;  
            DataBank.Login_sotr = login;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }


            string query = "SELECT COUNT(*) FROM workers where login = @login AND password = @password";
            db.OpenConnection();
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, db.getConnection()))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);

                    int countUser = Convert.ToInt32(command.ExecuteScalar());

                    if (countUser > 0)
                    {
                        database db = new database();
                        int clientId = db.GetClientIdByLogin_sotr(login);

                        if (clientId != -1)
                        {
                            DataBank.id_sotr = clientId;
                        }
                        else
                        {
                            MessageBox.Show("Не удалось получить ID клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MessageBox.Show("Авторизация прошла успешно");
                        obrabotka obr = new obrabotka();
                        this.Hide();
                        obr.ShowDialog();
                        this.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("не подключился " + ex);
                return;
            }
            finally
            {
                db.CloseConnection();
            }


        }

        private void back_but_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}

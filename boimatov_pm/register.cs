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
    public partial class register : Form
    {
        database db = new database();
        public register()
        {
            InitializeComponent();
        }

        private void login_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_but_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            this.Hide();
            form1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void reg_but_Click(object sender, EventArgs e)
        {
            registerUser();
        }

        private void registerUser()
        {
            var login = login_text.Text;
            var password = password_text.Text;
            var fio = FIO_text.Text;
            int age = Convert.ToInt32(age_text.Text);
            int seria_number = Convert.ToInt32(seriaNumber_text.Text);
            var vidan = kemVidan_text.Text;
            int snils = Convert.ToInt32(snils_text.Text);
            var email = email_text.Text;
            var phone = phone_text.Text;
            var fioParent = FIOParent_text.Text;
            var lastObr = lastObr_text.Text;


            string insertQuery = $"insert into clients (fio, age, seria_number, kem_vidan, snils, email, phone, fio_parent, last_obr, login, password) values ('{fio}', '{age}', '{seria_number}', '{vidan}', '{snils}', '{email}', '{phone}', '{fioParent}', '{lastObr}', '{login}', '{password}')";

            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Пожалуйста, введите логин.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                login_text.Focus();
                return ;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password_text.Focus();
                return ;
            }

            if (string.IsNullOrWhiteSpace(fio))
            {
                MessageBox.Show("Пожалуйста, введите ФИО.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FIO_text.Focus();
                return ;
            }

            if (string.IsNullOrWhiteSpace(vidan))
            {
                MessageBox.Show("Пожалуйста, введите кем выдан.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kemVidan_text.Focus();
                return ;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Пожалуйста, введите email.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email_text.Focus();
                return ;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Пожалуйста, введите телефон.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone_text.Focus();
                return ;
            }

            if (string.IsNullOrWhiteSpace(fioParent))
            {
                MessageBox.Show("Пожалуйста, введите ФИО родителя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FIOParent_text.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(lastObr))
            {
                MessageBox.Show("Пожалуйста, введите дату последнего обращения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastObr_text.Focus();
                return ;
            }

            db.OpenConnection();
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, db.getConnection()))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Регистрация прошла успешно");
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.ShowDialog();
                        this.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                        return;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }




        }
    }
}

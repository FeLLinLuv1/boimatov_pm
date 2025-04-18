using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace boimatov_pm
{
    internal class database
    {
        private NpgsqlConnection npgsqlConnection;
        private string connectionString = "Host=127.0.0.1;Port=5433;Database=pmBoimatov_ger;Username=postgres;Password=1234;"; // Лучше хранить в файле конфигурации

        public database()
        {
            npgsqlConnection = new NpgsqlConnection(connectionString);
        }
        public void OpenConnection ()
        {
            if (npgsqlConnection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    npgsqlConnection.Open ();
                }
                catch(NpgsqlException ex)
                {
                    MessageBox.Show($"Ошибка подключения к бд: {ex.Message}");
                    throw;
                }
            }
        }

        public void CloseConnection()
        {
            if (npgsqlConnection.State == System.Data.ConnectionState.Open)
            {
                npgsqlConnection.Close ();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return npgsqlConnection;
        }

        public DataTable ExecuteQuery(string sql)
        {
            DataTable dataTable = new DataTable();
            OpenConnection ();
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql, npgsqlConnection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show (ex.Message + " запроса: " + sql);
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
        public int ExecuteNonQuery(string sql)
        {
            int rowsAffected = 0;
            OpenConnection ();
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand (sql, npgsqlConnection))
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return rowsAffected;
        }

        public int GetClientIdByLogin(string login)
        {
            int clientId = -1; // Значение по умолчанию, если ID не найден

            OpenConnection();
            try
            {
                string query = "SELECT id FROM clients WHERE login = @login";
                using (NpgsqlCommand command = new NpgsqlCommand(query, getConnection()))
                {
                    command.Parameters.AddWithValue("@login", login);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        clientId = Convert.ToInt32(result);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при получении ID клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            finally
            {
                CloseConnection();
            }
            return clientId;
        }

        public int GetClientIdByLogin_sotr(string login)
        {
            int clientId = -1; // Значение по умолчанию, если ID не найден

            OpenConnection();
            try
            {
                string query = "SELECT id FROM workers WHERE login = @login";
                using (NpgsqlCommand command = new NpgsqlCommand(query, getConnection()))
                {
                    command.Parameters.AddWithValue("@login", login);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        clientId = Convert.ToInt32(result);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при получении ID клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                CloseConnection();
            }
            return clientId;
        }

        public int GetNapravleniyaIdByName(string napravleniyaName)
        {
            int napravleniyaId = -1; // Значение по умолчанию, если ID не найден

            OpenConnection();
            try
            {
                string query = "SELECT id FROM napravlen WHERE name = @name";
                using (NpgsqlCommand command = new NpgsqlCommand(query, getConnection()))
                {
                    command.Parameters.AddWithValue("@name", napravleniyaName);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        napravleniyaId = Convert.ToInt32(result);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при получении ID направления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Можно залогировать ошибку
            }
            finally
            {
                CloseConnection();
            }
            return napravleniyaId;
        }



    }
}

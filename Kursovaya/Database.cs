using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Data.Common;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Kursovaya
{
    class Database
    {
        private readonly string dataSource;
        public Database(string dataSource)
        {
            this.dataSource = dataSource;
        }
        public bool InitializeDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "DROP TABLE IF EXISTS users;"
                    + "CREATE TABLE users("
                    + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                    + "login TEXT, "
                    + "password TEXT); ";
                    cmd.CommandText = sql_command;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    SQLiteCommand cmd2 = conn.CreateCommand();
                    string sql_command2 = "DROP TABLE IF EXISTS day_calendar;"
                    + "CREATE TABLE day_calendar("
                    + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                    + "time TEXT, "
                    + "task TEXT, "
                    + "description TEXT, "
                    + "login TEXT; ";
                    cmd2.CommandText = sql_command2;
                    cmd2.ExecuteNonQuery();
                    conn.Close();

                }
                conn.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return true;
        }
        private static string GetMD5Hash(string text) //для хранения пароля в хэшированном виде
        {
            using (var hashAlg = MD5.Create())
            {
                byte[] hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(text));
                var builder = new StringBuilder(hash.Length * 2);
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("X2"));
                }
                return builder.ToString();
            }
        }
        public bool createUser(string login, string password) //регистрация
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                var pass = GetMD5Hash(password); //при регистрации пароль подается в БД сразу в хэшированном виде
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("INSERT INTO users (login, password)"
                + "VALUES ('{0}', '{1}')",
                login, pass);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            return true;
        }
        public bool checkUser(User user) //проверка логина и пароля при авторизации
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    var pass = GetMD5Hash(user.Password); //при авторизации пароль сразу подается в БД в хэшированном виде и сравнивается с хранящимся там
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("SELECT COUNT(login)"
                    + "FROM users "
                    + "where login = '{0}' AND "
                    + "password = '{1}'",
                    user.Login, pass);
                    var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                    return usersCount > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information); //выведем сообщение о возникшем исключении
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return false;
        }
        public bool Exists(string login)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM users;", conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                string tempLogin;
                foreach (DbDataRecord record in reader)
                {
                    tempLogin = record["login"].ToString();
                    if (login == tempLogin)
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Information); //выведем сообщение о возникшем исключении
            }
            finally
            {
                conn.Dispose();
            }
            return false;
        }
    }
}

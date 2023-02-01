using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kursovaya
{
    public partial class FormMain : Form
    {
        String connString = @"Data Source=dataBase.db;Version=3";
        public FormMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DialogResult authDialogResult = new FormAuth().ShowDialog();

            if (authDialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти??", "Eager Beaver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное приложение поможет оптимизировать ваш день!", "Возможности приложения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти??", "Eager Beaver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void информацияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Данное приложение поможет оптимизировать ваш день!", "Возможности приложения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSaveDay_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                conn.Open();
                String sql1 = "UPDATE day_calendar SET time = @time, task = @task, description = @description, login = @login WHERE id = 1";
                SQLiteCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = sql1;
                if (textBox9.Text.Trim() != "" && textBox1.Text.Trim() != "" && textBoxLogin.Text.Trim() != "")
                {
                    cmd1.Parameters.AddWithValue("@time", textBox9.Text);
                    cmd1.Parameters.AddWithValue("@task", textBox1.Text);
                    cmd1.Parameters.AddWithValue("@description", richTextBox5.Text);
                    cmd1.Parameters.AddWithValue("@login", textBoxLogin.Text);
                    cmd1.ExecuteNonQuery();
                }
                cmd1.Dispose();

                String sql2 = "UPDATE day_calendar SET time = @time, task = @task, description = @description, login = @login WHERE id = 2";
                SQLiteCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = sql2;
                if (textBox10.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBoxLogin.Text.Trim() != "")
                {
                    cmd2.Parameters.AddWithValue("time", textBox10.Text);
                    cmd2.Parameters.AddWithValue("task", textBox2.Text);
                    cmd2.Parameters.AddWithValue("description", richTextBox1.Text);
                    cmd2.Parameters.AddWithValue("login", textBoxLogin.Text);
                    cmd2.ExecuteNonQuery();
                }
                cmd2.Dispose();

                String sql3 = "UPDATE day_calendar SET time = @time, task = @task, description = @description, login = @login WHERE id = 3";
                SQLiteCommand cmd3 = conn.CreateCommand();
                cmd3.CommandText = sql3;
                if (textBox11.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBoxLogin.Text.Trim() != "")
                {
                    cmd3.Parameters.AddWithValue("time", textBox11.Text);
                    cmd3.Parameters.AddWithValue("task", textBox3.Text);
                    cmd3.Parameters.AddWithValue("description", richTextBox2.Text);
                    cmd3.Parameters.AddWithValue("login", textBoxLogin.Text);
                    cmd3.ExecuteNonQuery();
                }
                cmd3.Dispose();

                String sql4 = "UPDATE day_calendar SET time = @time, task = @task, description = @description, login = @login WHERE id = 4";
                SQLiteCommand cmd4 = conn.CreateCommand();
                cmd4.CommandText = sql4;
                if (textBox12.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBoxLogin.Text.Trim() != "")
                {
                    cmd4.Parameters.AddWithValue("time", textBox12.Text);
                    cmd4.Parameters.AddWithValue("task", textBox4.Text);
                    cmd4.Parameters.AddWithValue("description", richTextBox3.Text);
                    cmd4.Parameters.AddWithValue("login", textBoxLogin.Text);
                    cmd4.ExecuteNonQuery();
                }
                cmd4.Dispose();

                String sql5 = "UPDATE day_calendar SET time = @time, task = @task, description = @description, login = @login WHERE id = 5";
                SQLiteCommand cmd5 = conn.CreateCommand();
                cmd5.CommandText = sql5;
                if (textBox13.Text.Trim() != "" && textBox8.Text.Trim() != "" && textBoxLogin.Text.Trim() != "")
                {
                    cmd5.Parameters.AddWithValue("time", textBox13.Text);
                    cmd5.Parameters.AddWithValue("task", textBox8.Text);
                    cmd5.Parameters.AddWithValue("description", richTextBox4.Text);
                    cmd5.Parameters.AddWithValue("login", textBoxLogin.Text);
                    cmd5.ExecuteNonQuery();
                }
                cmd5.Dispose();

                String sql6 = "UPDATE day_calendar SET time = @time, task = @task, description = @description, login = @login WHERE id = 6";
                SQLiteCommand cmd6 = conn.CreateCommand();
                cmd6.CommandText = sql6;
                if (textBox14.Text.Trim() != "" && textBox7.Text.Trim() != "" && textBoxLogin.Text.Trim() != "")
                {
                    cmd6.Parameters.AddWithValue("time", textBox14.Text);
                    cmd6.Parameters.AddWithValue("task", textBox7.Text);
                    cmd6.Parameters.AddWithValue("description", richTextBox6.Text);
                    cmd6.Parameters.AddWithValue("login", textBoxLogin.Text);
                    cmd6.ExecuteNonQuery();
                }
                cmd6.Dispose();

                String sql7 = "UPDATE day_calendar SET time = @time, task = @task, description = @description, login = @login WHERE id = 7";
                SQLiteCommand cmd7 = conn.CreateCommand();
                cmd7.CommandText = sql7;
                if (textBox15.Text.Trim() != "" && textBox6.Text.Trim() != "" && textBoxLogin.Text.Trim() != "")
                {
                    cmd7.Parameters.AddWithValue("time", textBox15.Text);
                    cmd7.Parameters.AddWithValue("task", textBox6.Text);
                    cmd7.Parameters.AddWithValue("description", richTextBox7.Text);
                    cmd7.Parameters.AddWithValue("login", textBoxLogin.Text);
                    cmd7.ExecuteNonQuery();
                }
                cmd7.Dispose();

                String sql8 = "UPDATE day_calendar SET time = @time, task = @task, description = @description, login = @login WHERE id = 8";
                SQLiteCommand cmd8 = conn.CreateCommand();
                cmd8.CommandText = sql8;
                if (textBox16.Text.Trim() != "" && textBox5.Text.Trim() != "" && textBoxLogin.Text.Trim() != "")
                {
                    cmd8.Parameters.AddWithValue("time", textBox16.Text);
                    cmd8.Parameters.AddWithValue("task", textBox5.Text);
                    cmd8.Parameters.AddWithValue("description", richTextBox8.Text);
                    cmd8.Parameters.AddWithValue("login", textBoxLogin.Text);
                    cmd8.ExecuteNonQuery();
                }
                cmd8.Dispose();

                MessageBox.Show("Ваши задачи успешно сохранены", "Eager Beaver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "При сохранении задач произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        public void fillTextBox(List<string[]> data)
        {
            try
            {
                textBox9.Text = data[0][1];
                textBox1.Text = data[0][2];
                richTextBox5.Text = data[0][3];

                textBox10.Text = data[1][1];
                textBox2.Text = data[1][2];
                richTextBox1.Text = data[1][3];

                textBox11.Text = data[2][1];
                textBox3.Text = data[2][2];
                richTextBox2.Text = data[2][3];

                textBox12.Text = data[3][1];
                textBox4.Text = data[3][2];
                richTextBox3.Text = data[3][3];

                textBox13.Text = data[4][1];
                textBox8.Text = data[4][2];
                richTextBox4.Text = data[4][3];

                textBox14.Text = data[5][1];
                textBox7.Text = data[5][2];
                richTextBox6.Text = data[5][3];

                textBox15.Text = data[6][1];
                textBox6.Text = data[6][2];
                richTextBox7.Text = data[6][3];

                textBox16.Text = data[7][1];
                textBox5.Text = data[7][2];
                richTextBox8.Text = data[7][3];
                MessageBox.Show("Ваши задачи успешно загружены", "Eager Beaver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "При поиске задач произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();
            string login = textBoxLogin.Text.Trim();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("SELECT * "
                + "FROM day_calendar "
                + "WHERE login = '{0}' ",
                login);
            SQLiteDataReader reader = cmd.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();
            fillTextBox(data);
            conn.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox1.Text = "";
            richTextBox5.Text = "";

            textBox10.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";

            textBox11.Text = "";
            textBox3.Text = "";
            richTextBox2.Text = ""; ;

            textBox12.Text = "";
            textBox4.Text = "";
            richTextBox3.Text = "";

            textBox13.Text = "";
            textBox8.Text = "";
            richTextBox4.Text = "";

            textBox14.Text = "";
            textBox7.Text = "";
            richTextBox6.Text = "";

            textBox15.Text = "";
            textBox6.Text = "";
            richTextBox7.Text = "";

            textBox16.Text = "";
            textBox5.Text = "";
            richTextBox8.Text = "";

            try
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                conn.Open();
                String sql1 = "UPDATE day_calendar SET time = @time, task = @task, description = @description";
                SQLiteCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = sql1;
                cmd1.Parameters.AddWithValue("@time", textBox9.Text);
                cmd1.Parameters.AddWithValue("@task", textBox1.Text);
                cmd1.Parameters.AddWithValue("@description", richTextBox5.Text);
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                MessageBox.Show("Все задачи успешно удалены", "Eager Beaver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "При удалении задач произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

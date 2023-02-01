using System;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBoxLogin.MaxLength = 20;
            textBoxPassword.MaxLength = 20;
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = textBoxLogin.Text.Trim();
            textBoxPassword.Text = textBoxPassword.Text.Trim();
            if (userAuthSucceess())
                this.DialogResult = DialogResult.OK;
            else
                return;
        }
        private bool userAuthSucceess()
        {
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Заполните все поля", "Eager Beaver", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (hasUser(textBoxLogin.Text, textBoxPassword.Text))
                return true;
            else
            {
                MessageBox.Show("Введенный логин или пароль неправильный", "Eager Beaver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(textBoxLogin.Text) || isUnCorrectField(textBoxPassword.Text))
                return true;
            return false;
        }

        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field))
                return true;
            return false;
        }
        private bool hasUser(string login, string password)
        {
            User user = new User(login, password);
            return user.IsCorrect();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное приложение поможет оптимизировать ваш день!", "Возможности приложения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти??", "Eager Beaver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult Reg = new FormRegist().ShowDialog();
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }

        private void checkBoxShowAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowAuth.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

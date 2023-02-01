namespace Kursovaya
{
    partial class FormAuth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelRegistration = new System.Windows.Forms.LinkLabel();
            this.checkBoxShowAuth = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.Wheat;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Location = new System.Drawing.Point(296, 168);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(216, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Wheat;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Location = new System.Drawing.Point(296, 242);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(216, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(301, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(301, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // buttonAuth
            // 
            this.buttonAuth.BackColor = System.Drawing.Color.Wheat;
            this.buttonAuth.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuth.Location = new System.Drawing.Point(338, 304);
            this.buttonAuth.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(98, 32);
            this.buttonAuth.TabIndex = 4;
            this.buttonAuth.Text = "Войти";
            this.buttonAuth.UseVisualStyleBackColor = false;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SaddleBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(550, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.помощьToolStripMenuItem.Text = "О приложении";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(263, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Если у Вас нет аккаунта, Вы можете";
            // 
            // linkLabelRegistration
            // 
            this.linkLabelRegistration.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelRegistration.AutoSize = true;
            this.linkLabelRegistration.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelRegistration.DisabledLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabelRegistration.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelRegistration.LinkColor = System.Drawing.Color.Black;
            this.linkLabelRegistration.Location = new System.Drawing.Point(317, 371);
            this.linkLabelRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelRegistration.Name = "linkLabelRegistration";
            this.linkLabelRegistration.Size = new System.Drawing.Size(159, 22);
            this.linkLabelRegistration.TabIndex = 7;
            this.linkLabelRegistration.TabStop = true;
            this.linkLabelRegistration.Text = "зарегистрироваться";
            this.linkLabelRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistration_LinkClicked);
            // 
            // checkBoxShowAuth
            // 
            this.checkBoxShowAuth.AutoSize = true;
            this.checkBoxShowAuth.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowAuth.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowAuth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxShowAuth.Location = new System.Drawing.Point(308, 271);
            this.checkBoxShowAuth.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxShowAuth.Name = "checkBoxShowAuth";
            this.checkBoxShowAuth.Size = new System.Drawing.Size(124, 21);
            this.checkBoxShowAuth.TabIndex = 8;
            this.checkBoxShowAuth.Text = "Показать пароль";
            this.checkBoxShowAuth.UseVisualStyleBackColor = false;
            this.checkBoxShowAuth.CheckedChanged += new System.EventHandler(this.checkBoxShowAuth_CheckedChanged);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 540);
            this.Controls.Add(this.checkBoxShowAuth);
            this.Controls.Add(this.linkLabelRegistration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAuth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 579);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(566, 579);
            this.Name = "FormAuth";
            this.Text = "Eager Beaver - Авторизация";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelRegistration;
        private System.Windows.Forms.CheckBox checkBoxShowAuth;
    }
}
namespace BankApplikationForm
{
    partial class User
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonChangePassword = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            textBoxNewPassword = new TextBox();
            label1 = new Label();
            textBoxOldPassword = new TextBox();
            changePasswordLabel = new Label();
            LogOutUserBottone = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            listBox2 = new ListBox();
            buttonDeleteAccaunt = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(560, 270);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonChangePassword);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBoxNewPassword);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxOldPassword);
            tabPage1.Controls.Add(changePasswordLabel);
            tabPage1.Controls.Add(LogOutUserBottone);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(552, 242);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.Location = new Point(316, 144);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(132, 32);
            buttonChangePassword.TabIndex = 7;
            buttonChangePassword.Text = "Change Password";
            buttonChangePassword.UseVisualStyleBackColor = true;
            buttonChangePassword.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(5, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 139);
            listBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 111);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 5;
            label2.Text = "New Password";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(316, 103);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(189, 23);
            textBoxNewPassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 71);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // textBoxOldPassword
            // 
            textBoxOldPassword.Location = new Point(316, 63);
            textBoxOldPassword.Name = "textBoxOldPassword";
            textBoxOldPassword.Size = new Size(189, 23);
            textBoxOldPassword.TabIndex = 2;
            // 
            // changePasswordLabel
            // 
            changePasswordLabel.AutoSize = true;
            changePasswordLabel.Location = new Point(360, 37);
            changePasswordLabel.Name = "changePasswordLabel";
            changePasswordLabel.Size = new Size(101, 15);
            changePasswordLabel.TabIndex = 1;
            changePasswordLabel.Text = "Change Password";
            // 
            // LogOutUserBottone
            // 
            LogOutUserBottone.Location = new Point(400, 192);
            LogOutUserBottone.Name = "LogOutUserBottone";
            LogOutUserBottone.Size = new Size(144, 42);
            LogOutUserBottone.TabIndex = 0;
            LogOutUserBottone.Text = "Logg out";
            LogOutUserBottone.UseVisualStyleBackColor = true;
            LogOutUserBottone.Click += LogOutUserBottone_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(552, 242);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Deposit";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(552, 242);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Transaction";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(buttonDeleteAccaunt);
            tabPage4.Controls.Add(listBox2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2);
            tabPage4.Size = new Size(552, 242);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Delete Account";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(218, 5);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(326, 154);
            listBox2.TabIndex = 0;
            // 
            // buttonDeleteAccaunt
            // 
            buttonDeleteAccaunt.Location = new Point(316, 178);
            buttonDeleteAccaunt.Name = "buttonDeleteAccaunt";
            buttonDeleteAccaunt.Size = new Size(144, 42);
            buttonDeleteAccaunt.TabIndex = 1;
            buttonDeleteAccaunt.Text = "Delete";
            buttonDeleteAccaunt.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "User";
            Text = "User";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ListBox listBox2;
        private Button LogOutUserBottone;
        private Label label1;
        private TextBox textBoxOldPassword;
        private Label changePasswordLabel;
        private Label label2;
        private TextBox textBoxNewPassword;
        private ListBox listBox1;
        private Button buttonChangePassword;
        private Button buttonDeleteAccaunt;
    }
}
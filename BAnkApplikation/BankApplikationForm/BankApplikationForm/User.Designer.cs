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
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            AccountListBox = new ListBox();
            balanceLabel = new Label();
            selectAccountComboBox = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(640, 360);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(selectAccountComboBox);
            tabPage1.Controls.Add(balanceLabel);
            tabPage1.Controls.Add(AccountListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(632, 327);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(632, 327);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Deposit";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2, 2, 2, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 2, 2, 2);
            tabPage3.Size = new Size(632, 327);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Transaction";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2, 2, 2, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2, 2, 2, 2);
            tabPage4.Size = new Size(632, 327);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Delete Account";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // AccountListBox
            // 
            AccountListBox.FormattingEnabled = true;
            AccountListBox.ItemHeight = 20;
            AccountListBox.Location = new Point(5, 30);
            AccountListBox.Name = "AccountListBox";
            AccountListBox.Size = new Size(242, 244);
            AccountListBox.TabIndex = 0;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(56, 7);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(64, 20);
            balanceLabel.TabIndex = 1;
            balanceLabel.Text = "Balance:";
            // 
            // selectAccountComboBox
            // 
            selectAccountComboBox.FormattingEnabled = true;
            selectAccountComboBox.Location = new Point(370, 59);
            selectAccountComboBox.Name = "selectAccountComboBox";
            selectAccountComboBox.Size = new Size(151, 28);
            selectAccountComboBox.TabIndex = 2;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "User";
            Text = "User";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label balanceLabel;
        private ListBox AccountListBox;
        private ComboBox selectAccountComboBox;
    }
}
namespace BankApplikationForm
{
    partial class NewUser
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 33);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 85);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 148);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 204);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 3;
            label4.Text = "Adress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 263);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 4;
            label5.Text = "Contact Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 322);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 5;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 378);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 6;
            label7.Text = "Gender";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(271, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(271, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(271, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(271, 263);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 31);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(271, 322);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 31);
            textBox6.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(274, 383);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 33);
            comboBox1.TabIndex = 13;
            // 
            // NewAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "NewAccount";
            Text = "NewUser";
            BackgroundImageLayoutChanged += NewAccount_BackgroundImageLayoutChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
    }
}
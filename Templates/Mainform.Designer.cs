namespace Templates
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1_1 = new Button();
            groupBox1_1 = new GroupBox();
            userMiddleName = new TextBox();
            userFirstName = new TextBox();
            userLastName = new TextBox();
            groupBox1_2 = new GroupBox();
            totalStaySum = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            guestBirthDate = new DateTimePicker();
            guestFullName = new TextBox();
            button1_2 = new Button();
            groupBox2 = new GroupBox();
            button2_2 = new Button();
            richTextBoxOutput = new RichTextBox();
            button2_1 = new Button();
            button2_3 = new Button();
            groupBox1_1.SuspendLayout();
            groupBox1_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)totalStaySum).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1_1
            // 
            button1_1.Location = new Point(63, 173);
            button1_1.Name = "button1_1";
            button1_1.Size = new Size(153, 46);
            button1_1.TabIndex = 0;
            button1_1.Text = "Выполнить";
            button1_1.UseVisualStyleBackColor = true;
            button1_1.Click += button1_1_Click;
            // 
            // groupBox1_1
            // 
            groupBox1_1.Controls.Add(userMiddleName);
            groupBox1_1.Controls.Add(userFirstName);
            groupBox1_1.Controls.Add(userLastName);
            groupBox1_1.Controls.Add(button1_1);
            groupBox1_1.Location = new Point(12, 12);
            groupBox1_1.Name = "groupBox1_1";
            groupBox1_1.Size = new Size(230, 229);
            groupBox1_1.TabIndex = 1;
            groupBox1_1.TabStop = false;
            groupBox1_1.Text = "Задание 1.1";
            // 
            // userMiddleName
            // 
            userMiddleName.Location = new Point(16, 128);
            userMiddleName.Name = "userMiddleName";
            userMiddleName.PlaceholderText = "Отчество";
            userMiddleName.Size = new Size(200, 39);
            userMiddleName.TabIndex = 3;
            // 
            // userFirstName
            // 
            userFirstName.Location = new Point(16, 83);
            userFirstName.Name = "userFirstName";
            userFirstName.PlaceholderText = "Имя";
            userFirstName.Size = new Size(200, 39);
            userFirstName.TabIndex = 2;
            // 
            // userLastName
            // 
            userLastName.Location = new Point(16, 38);
            userLastName.Name = "userLastName";
            userLastName.PlaceholderText = "Фамилия";
            userLastName.Size = new Size(200, 39);
            userLastName.TabIndex = 1;
            // 
            // groupBox1_2
            // 
            groupBox1_2.Controls.Add(totalStaySum);
            groupBox1_2.Controls.Add(label3);
            groupBox1_2.Controls.Add(label2);
            groupBox1_2.Controls.Add(label1);
            groupBox1_2.Controls.Add(guestBirthDate);
            groupBox1_2.Controls.Add(guestFullName);
            groupBox1_2.Controls.Add(button1_2);
            groupBox1_2.Location = new Point(253, 12);
            groupBox1_2.Name = "groupBox1_2";
            groupBox1_2.Size = new Size(661, 229);
            groupBox1_2.TabIndex = 2;
            groupBox1_2.TabStop = false;
            groupBox1_2.Text = "Задание 1.2";
            // 
            // totalStaySum
            // 
            totalStaySum.DecimalPlaces = 2;
            totalStaySum.Location = new Point(376, 128);
            totalStaySum.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            totalStaySum.Name = "totalStaySum";
            totalStaySum.Size = new Size(271, 39);
            totalStaySum.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.Location = new Point(252, 128);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 6;
            label3.Text = "Сумма (,):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Location = new Point(181, 86);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 5;
            label2.Text = "Дата рождения:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Location = new Point(125, 41);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 4;
            label1.Text = "ФИО:";
            // 
            // guestBirthDate
            // 
            guestBirthDate.Location = new Point(376, 83);
            guestBirthDate.Name = "guestBirthDate";
            guestBirthDate.Size = new Size(271, 39);
            guestBirthDate.TabIndex = 4;
            // 
            // guestFullName
            // 
            guestFullName.Location = new Point(203, 38);
            guestFullName.Name = "guestFullName";
            guestFullName.Size = new Size(444, 39);
            guestFullName.TabIndex = 1;
            // 
            // button1_2
            // 
            button1_2.Location = new Point(494, 173);
            button1_2.Name = "button1_2";
            button1_2.Size = new Size(153, 46);
            button1_2.TabIndex = 0;
            button1_2.Text = "Выполнить";
            button1_2.UseVisualStyleBackColor = true;
            button1_2.Click += button1_2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2_3);
            groupBox2.Controls.Add(button2_2);
            groupBox2.Controls.Add(richTextBoxOutput);
            groupBox2.Controls.Add(button2_1);
            groupBox2.Location = new Point(12, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(902, 544);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задания 2";
            // 
            // button2_2
            // 
            button2_2.Location = new Point(6, 106);
            button2_2.Name = "button2_2";
            button2_2.Size = new Size(153, 46);
            button2_2.TabIndex = 6;
            button2_2.Text = "Задание 2.2";
            button2_2.UseVisualStyleBackColor = true;
            button2_2.Click += button2_2_Click;
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.ForeColor = SystemColors.MenuHighlight;
            richTextBoxOutput.Location = new Point(182, 38);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.Size = new Size(706, 490);
            richTextBoxOutput.TabIndex = 5;
            richTextBoxOutput.Text = "";
            // 
            // button2_1
            // 
            button2_1.Location = new Point(6, 54);
            button2_1.Name = "button2_1";
            button2_1.Size = new Size(153, 46);
            button2_1.TabIndex = 4;
            button2_1.Text = "Задание 2.1";
            button2_1.UseVisualStyleBackColor = true;
            button2_1.Click += button2_1_Click;
            // 
            // button2_3
            // 
            button2_3.Location = new Point(6, 158);
            button2_3.Name = "button2_3";
            button2_3.Size = new Size(153, 46);
            button2_3.TabIndex = 7;
            button2_3.Text = "Задание 2.3";
            button2_3.UseVisualStyleBackColor = true;
            button2_3.Click += button2_3_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(926, 796);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1_2);
            Controls.Add(groupBox1_1);
            MaximizeBox = false;
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tests";
            Load += Mainform_Load;
            groupBox1_1.ResumeLayout(false);
            groupBox1_1.PerformLayout();
            groupBox1_2.ResumeLayout(false);
            groupBox1_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)totalStaySum).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1_1;
        private GroupBox groupBox1_1;
        private TextBox userLastName;
        private TextBox userMiddleName;
        private TextBox userFirstName;
        private GroupBox groupBox1_2;
        private TextBox guestFullName;
        private Button button1_2;
        private DateTimePicker guestBirthDate;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown totalStaySum;
        private GroupBox groupBox2;
        private Button button2_1;
        private RichTextBox richTextBoxOutput;
        private Button button2_2;
        private Button button2_3;
    }
}

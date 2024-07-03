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
            groupBox1_1.SuspendLayout();
            groupBox1_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)totalStaySum).BeginInit();
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
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(926, 256);
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
    }
}

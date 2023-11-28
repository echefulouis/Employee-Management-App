namespace EmployeeRecordApp
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            label2 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            EmpNameTb = new TextBox();
            button2 = new Button();
            button1 = new Button();
            AddEmployeeBtn = new Button();
            EmployeeList = new DataGridView();
            EmpGenderCb = new ComboBox();
            label6 = new Label();
            EmpPositionCb = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            EmpPhoneTb = new TextBox();
            label3 = new Label();
            EmpAddTb = new TextBox();
            label1 = new Label();
            EmpSsnTb = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(206, 25);
            label2.TabIndex = 4;
            label2.Text = "Manage Employee";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(AddEmployeeBtn);
            panel1.Controls.Add(EmployeeList);
            panel1.Controls.Add(EmpGenderCb);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EmpPositionCb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(EmpPhoneTb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EmpSsnTb);
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 316);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 57);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 18;
            label7.Text = "Employee Name";
            label7.Click += label7_Click;
            // 
            // EmpNameTb
            // 
            EmpNameTb.Location = new Point(162, 59);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(167, 23);
            EmpNameTb.TabIndex = 17;
            EmpNameTb.TextChanged += EmpNameTb_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(251, 252);
            button2.Name = "button2";
            button2.Size = new Size(96, 37);
            button2.TabIndex = 16;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(131, 252);
            button1.Name = "button1";
            button1.Size = new Size(96, 37);
            button1.TabIndex = 15;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddEmployeeBtn
            // 
            AddEmployeeBtn.BackColor = SystemColors.ActiveCaptionText;
            AddEmployeeBtn.FlatAppearance.BorderSize = 0;
            AddEmployeeBtn.FlatStyle = FlatStyle.Flat;
            AddEmployeeBtn.ForeColor = Color.White;
            AddEmployeeBtn.Location = new Point(12, 252);
            AddEmployeeBtn.Name = "AddEmployeeBtn";
            AddEmployeeBtn.Size = new Size(96, 37);
            AddEmployeeBtn.TabIndex = 14;
            AddEmployeeBtn.Text = "Add";
            AddEmployeeBtn.UseVisualStyleBackColor = false;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            // 
            // EmployeeList
            // 
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeList.Location = new Point(389, 15);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.RowTemplate.Height = 25;
            EmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeList.Size = new Size(523, 286);
            EmployeeList.TabIndex = 13;
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // EmpGenderCb
            // 
            EmpGenderCb.FormattingEnabled = true;
            EmpGenderCb.Items.AddRange(new object[] { "Male", "Female" });
            EmpGenderCb.Location = new Point(162, 170);
            EmpGenderCb.Name = "EmpGenderCb";
            EmpGenderCb.Size = new Size(167, 23);
            EmpGenderCb.TabIndex = 10;
            EmpGenderCb.SelectedIndexChanged += EmpGenderCb_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 172);
            label6.Name = "label6";
            label6.Size = new Size(133, 21);
            label6.TabIndex = 9;
            label6.Text = "Employee Gender";
            label6.Click += label6_Click;
            // 
            // EmpPositionCb
            // 
            EmpPositionCb.FormattingEnabled = true;
            EmpPositionCb.Items.AddRange(new object[] { "Manager", "Senior Developer", "Junior Developer", "Accountant", "Receptionist" });
            EmpPositionCb.Location = new Point(162, 210);
            EmpPositionCb.Name = "EmpPositionCb";
            EmpPositionCb.Size = new Size(167, 23);
            EmpPositionCb.TabIndex = 8;
            EmpPositionCb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 212);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 7;
            label5.Text = "Employee Position";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 5;
            label4.Text = "Employee Phone";
            label4.Click += label4_Click;
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.Location = new Point(162, 137);
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(167, 23);
            EmpPhoneTb.TabIndex = 4;
            EmpPhoneTb.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 3;
            label3.Text = "Employee Address";
            label3.Click += label3_Click;
            // 
            // EmpAddTb
            // 
            EmpAddTb.Location = new Point(162, 97);
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(167, 23);
            EmpAddTb.TabIndex = 2;
            EmpAddTb.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 1;
            label1.Text = "Employee SSN";
            label1.Click += label1_Click;
            // 
            // EmpSsnTb
            // 
            EmpSsnTb.Location = new Point(162, 26);
            EmpSsnTb.Name = "EmpSsnTb";
            EmpSsnTb.Size = new Size(167, 23);
            EmpSsnTb.TabIndex = 0;
            EmpSsnTb.TextChanged += EmpSsnTb_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(855, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(924, 405);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private ComboBox EmpPositionCb;
        private Label label5;
        private Label label4;
        private TextBox EmpPhoneTb;
        private Label label3;
        private TextBox EmpAddTb;
        private Label label1;
        private TextBox EmpSsnTb;
        private DataGridView EmployeeList;
        private ComboBox EmpGenderCb;
        private Label label6;
        private Button button2;
        private Button button1;
        private Button AddEmployeeBtn;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox EmpNameTb;
    }
}
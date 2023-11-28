namespace EmployeeRecordApp
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            EmpSsnTb = new TextBox();
            label1 = new Label();
            WorkedTb = new TextBox();
            label3 = new Label();
            label5 = new Label();
            EmpPositionCb = new ComboBox();
            AddEmployeeBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            EmpNameTb = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            SalarySlip = new RichTextBox();
            label4 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(868, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 10;
            label2.Text = "Salary";
            // 
            // EmpSsnTb
            // 
            EmpSsnTb.Location = new Point(404, 16);
            EmpSsnTb.Name = "EmpSsnTb";
            EmpSsnTb.Size = new Size(167, 23);
            EmpSsnTb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(277, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 1;
            label1.Text = "Employee SSN";
            // 
            // WorkedTb
            // 
            WorkedTb.Location = new Point(183, 154);
            WorkedTb.Name = "WorkedTb";
            WorkedTb.Size = new Size(167, 23);
            WorkedTb.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 154);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 3;
            label3.Text = "Worked Hours";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 110);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 7;
            label5.Text = "Employee Position";
            // 
            // EmpPositionCb
            // 
            EmpPositionCb.FormattingEnabled = true;
            EmpPositionCb.Items.AddRange(new object[] { "Manager", "Senior Developer", "Junior Developer", "Accountant", "Receptionist" });
            EmpPositionCb.Location = new Point(183, 112);
            EmpPositionCb.Name = "EmpPositionCb";
            EmpPositionCb.Size = new Size(167, 23);
            EmpPositionCb.TabIndex = 8;
            // 
            // AddEmployeeBtn
            // 
            AddEmployeeBtn.BackColor = SystemColors.ActiveCaptionText;
            AddEmployeeBtn.FlatAppearance.BorderSize = 0;
            AddEmployeeBtn.FlatStyle = FlatStyle.Flat;
            AddEmployeeBtn.ForeColor = Color.White;
            AddEmployeeBtn.Location = new Point(183, 227);
            AddEmployeeBtn.Name = "AddEmployeeBtn";
            AddEmployeeBtn.Size = new Size(96, 37);
            AddEmployeeBtn.TabIndex = 14;
            AddEmployeeBtn.Text = "View";
            AddEmployeeBtn.UseVisualStyleBackColor = false;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(667, 273);
            button1.Name = "button1";
            button1.Size = new Size(96, 37);
            button1.TabIndex = 15;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(53, 227);
            button2.Name = "button2";
            button2.Size = new Size(96, 37);
            button2.TabIndex = 16;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EmpNameTb
            // 
            EmpNameTb.Location = new Point(183, 75);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(167, 23);
            EmpNameTb.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 73);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 18;
            label7.Text = "Employee Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(SalarySlip);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(AddEmployeeBtn);
            panel1.Controls.Add(EmpPositionCb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(WorkedTb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EmpSsnTb);
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 316);
            panel1.TabIndex = 12;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(577, 11);
            button3.Name = "button3";
            button3.Size = new Size(89, 31);
            button3.TabIndex = 20;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // SalarySlip
            // 
            SalarySlip.BackColor = Color.Gainsboro;
            SalarySlip.BorderStyle = BorderStyle.None;
            SalarySlip.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SalarySlip.ForeColor = Color.DarkBlue;
            SalarySlip.Location = new Point(496, 60);
            SalarySlip.Name = "SalarySlip";
            SalarySlip.Size = new Size(400, 185);
            SalarySlip.TabIndex = 19;
            SalarySlip.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 114);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 7;
            label4.Text = "Employee Position";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(908, 366);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private TextBox EmpSsnTb;
        private Label label1;
        private TextBox WorkedTb;
        private Label label3;
        private Label label5;
        private ComboBox EmpPositionCb;
        private Button AddEmployeeBtn;
        private Button button1;
        private Button button2;
        private TextBox EmpNameTb;
        private Label label7;
        private Panel panel1;
        private Label label4;
        private RichTextBox SalarySlip;
        private Button button3;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
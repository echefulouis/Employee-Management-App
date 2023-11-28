namespace EmployeeRecordApp
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            pictureBox1 = new PictureBox();
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            PrintBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            empSSNSearchTb = new TextBox();
            panel1 = new Panel();
            empGenderLbl = new Label();
            empPositionLbl = new Label();
            empNameLbl = new Label();
            empPhoneLbl = new Label();
            empAddLbl = new Label();
            label2 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(861, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(104, 64);
            label7.Name = "label7";
            label7.Size = new Size(133, 21);
            label7.TabIndex = 18;
            label7.Text = "Employee Name:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(596, 5);
            button2.Name = "button2";
            button2.Size = new Size(65, 30);
            button2.TabIndex = 16;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(605, 252);
            button1.Name = "button1";
            button1.Size = new Size(96, 37);
            button1.TabIndex = 15;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = SystemColors.ActiveCaptionText;
            PrintBtn.FlatAppearance.BorderSize = 0;
            PrintBtn.FlatStyle = FlatStyle.Flat;
            PrintBtn.ForeColor = Color.White;
            PrintBtn.Location = new Point(317, 252);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(96, 37);
            PrintBtn.TabIndex = 14;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(504, 64);
            label6.Name = "label6";
            label6.Size = new Size(140, 21);
            label6.TabIndex = 9;
            label6.Text = "Employee Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(504, 132);
            label5.Name = "label5";
            label5.Size = new Size(144, 21);
            label5.TabIndex = 7;
            label5.Text = "Employee Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(104, 187);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 5;
            label4.Text = "Employee Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(104, 132);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 3;
            label3.Text = "Employee Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(286, 10);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 1;
            label1.Text = "Employee SSN";
            label1.Click += label1_Click;
            // 
            // empSSNSearchTb
            // 
            empSSNSearchTb.Location = new Point(404, 10);
            empSSNSearchTb.Name = "empSSNSearchTb";
            empSSNSearchTb.Size = new Size(167, 23);
            empSSNSearchTb.TabIndex = 0;
            empSSNSearchTb.TextChanged += EmpSsnTb_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(empGenderLbl);
            panel1.Controls.Add(empPositionLbl);
            panel1.Controls.Add(empNameLbl);
            panel1.Controls.Add(empPhoneLbl);
            panel1.Controls.Add(empAddLbl);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PrintBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(empSSNSearchTb);
            panel1.Location = new Point(-1, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 316);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // empGenderLbl
            // 
            empGenderLbl.AutoSize = true;
            empGenderLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            empGenderLbl.ForeColor = Color.DarkBlue;
            empGenderLbl.Location = new Point(661, 64);
            empGenderLbl.Name = "empGenderLbl";
            empGenderLbl.Size = new Size(133, 21);
            empGenderLbl.TabIndex = 23;
            empGenderLbl.Text = "Employee Gender";
            empGenderLbl.Visible = false;
            empGenderLbl.Click += empGenderLbl_Click;
            // 
            // empPositionLbl
            // 
            empPositionLbl.AutoSize = true;
            empPositionLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            empPositionLbl.ForeColor = Color.DarkBlue;
            empPositionLbl.Location = new Point(661, 132);
            empPositionLbl.Name = "empPositionLbl";
            empPositionLbl.Size = new Size(137, 21);
            empPositionLbl.TabIndex = 22;
            empPositionLbl.Text = "Employee Position";
            empPositionLbl.Visible = false;
            empPositionLbl.Click += empPositionLbl_Click;
            // 
            // empNameLbl
            // 
            empNameLbl.AutoSize = true;
            empNameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            empNameLbl.ForeColor = Color.DarkBlue;
            empNameLbl.Location = new Point(264, 64);
            empNameLbl.Name = "empNameLbl";
            empNameLbl.Size = new Size(124, 21);
            empNameLbl.TabIndex = 21;
            empNameLbl.Text = "Employee Name";
            empNameLbl.Visible = false;
            empNameLbl.Click += empNameLbl_Click;
            // 
            // empPhoneLbl
            // 
            empPhoneLbl.AutoSize = true;
            empPhoneLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            empPhoneLbl.ForeColor = Color.DarkBlue;
            empPhoneLbl.Location = new Point(264, 187);
            empPhoneLbl.Name = "empPhoneLbl";
            empPhoneLbl.Size = new Size(126, 21);
            empPhoneLbl.TabIndex = 20;
            empPhoneLbl.Text = "Employee Phone";
            empPhoneLbl.Visible = false;
            empPhoneLbl.Click += empPhoneLbl_Click;
            // 
            // empAddLbl
            // 
            empAddLbl.AutoSize = true;
            empAddLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            empAddLbl.ForeColor = Color.DarkBlue;
            empAddLbl.Location = new Point(264, 132);
            empAddLbl.Name = "empAddLbl";
            empAddLbl.Size = new Size(138, 21);
            empAddLbl.TabIndex = 19;
            empAddLbl.Text = "Employee Address";
            empAddLbl.Visible = false;
            empAddLbl.Click += empAddLbl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 12);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 7;
            label2.Text = "Employee Details";
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
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ViewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(908, 366);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEmployee";
            Load += ViewEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label7;
        private Button button2;
        private Button button1;
        private Button PrintBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox empSSNSearchTb;
        private Panel panel1;
        private Label label2;
        private Label empNameLbl;
        private Label empPhoneLbl;
        private Label empAddLbl;
        private Label empGenderLbl;
        private Label empPositionLbl;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
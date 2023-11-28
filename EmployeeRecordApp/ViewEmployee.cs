using EmployeeRecordApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeRecordApp
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private EmployeeModel FetchEmpData(string inputSSN)
        {
            EmployeeModel emp = GlobalConfig.Connection.GetEmployeeBySSN(inputSSN);

            return emp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmpSsnTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ssnToSearch = empSSNSearchTb.Text;

            EmployeeModel employee = GlobalConfig.Connection.GetEmployeeBySSN(ssnToSearch);

            if (employee != null)
            {
                empNameLbl.Text = employee.EmpName.ToString();
                empPositionLbl.Text = employee.EmpPosition.ToString();
                empGenderLbl.Text = employee.EmpGender.ToString();
                empPhoneLbl.Text = employee.EmpPhone.ToString();
                empAddLbl.Text = employee.EmpAddress.ToString();

                empNameLbl.Visible = true;
                empPositionLbl.Visible = true;
                empGenderLbl.Visible = true;
                empPhoneLbl.Visible = true;
                empAddLbl.Visible = true;
            }
            else
            {
                MessageBox.Show("Employee with the SSN can't be found");
            }



        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void empNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void empAddLbl_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void empPhoneLbl_Click(object sender, EventArgs e)
        {
        }

        private void empPositionLbl_Click(object sender, EventArgs e)
        {
        }

        private void empGenderLbl_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("==EMPLOYEE RECORD DETAILS==", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(190));
            e.Graphics.DrawString("Employee Name: " + empNameLbl.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Employee Address: " + empAddLbl.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Blue, new Point(10, 150));
            e.Graphics.DrawString("Employee Gender: " + empGenderLbl.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Blue, new Point(10, 200));
            e.Graphics.DrawString("Employee Position: " + empPositionLbl.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Blue, new Point(10, 250));
            e.Graphics.DrawString("Employee Phone: " + empPhoneLbl.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Blue, new Point(10, 300));
        }
    }
}

using EmployeeRecordApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeRecordApp
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        private void fetchdata()
        {
            string ssnToSearch = EmpSsnTb.Text;

            EmployeeModel employee = GlobalConfig.Connection.GetEmployeeBySSN(ssnToSearch);

            if (employee != null)
            {
                EmpNameTb.Text = employee.EmpName.ToString();
                EmpPositionCb.Text = employee.EmpPosition.ToString();
            }
            else
            {
                MessageBox.Show("Employee with the SSN can't be found");
            }
        }
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fetchdata();
        }

        int Dailybase, total;
        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (EmpPositionCb.Text == "")
            {
                MessageBox.Show("Select an Employee");
            }
            else if (WorkedTb.Text == "" || Convert.ToInt32(WorkedTb.Text) > 100)
            {
                MessageBox.Show("Enter a valid number of Hours");
            }
            else
            {
                if (EmpPositionCb.Text == "Manager")
                {
                    Dailybase = 40;
                }
                else if (EmpPositionCb.Text == "Senior Developer")
                {
                    Dailybase = 35;
                }
                else if (EmpPositionCb.Text == "Junior Developer")
                {
                    Dailybase = 20;
                }
                else
                {
                    Dailybase = 15;
                }
                total = Dailybase * Convert.ToInt32(WorkedTb.Text);

                SalarySlip.Text = "Employee Name: " + EmpNameTb.Text + "\n" + "Employee Position: " + EmpPositionCb.Text + "\n"
                                 + "Hours Worked: " + WorkedTb.Text + "\n" + "Total Pay: $" + total;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("== SALARY SUMMARY==", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(190));
            e.Graphics.DrawString("Employee Name: " + EmpNameTb.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Employee Hours Worked: " + WorkedTb.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Blue, new Point(10, 200));
            e.Graphics.DrawString("Rate Per Hour: " + Dailybase, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Blue, new Point(10, 300));
            e.Graphics.DrawString("Total Salary Amount: $" + total, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Blue, new Point(10, 400));

        }
    }
}

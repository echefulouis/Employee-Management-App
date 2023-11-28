using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeRecordApp.Models;

namespace EmployeeRecordApp
{
    public partial class Employee : Form
    {
        int key = 0;

        private List<EmployeeModel> employees = GlobalConfig.Connection.GetAllEmployees();
        public Employee()
        {
            InitializeComponent();
            ShowEmployees();
        }

        private void ShowEmployees()
        {
            EmployeeList.DataSource = GlobalConfig.Connection.GetAllEmployees();
        }

        private void Clear()
        {
            EmpAddTb.Text = "";
            EmpNameTb.Text = "";
            EmpPhoneTb.Text = "";
            EmpSsnTb.Text = "";
            EmpGenderCb.SelectedIndex = -1;
            EmpPositionCb.SelectedIndex = -1;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (EmpSsnTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string empSSN = EmpSsnTb.Text;
                    string empName = EmpNameTb.Text;
                    string empPhone = EmpPhoneTb.Text;
                    string empAddress = EmpAddTb.Text;
                    string empGender = EmpGenderCb.SelectedItem.ToString();
                    string empPosition = EmpPositionCb.SelectedItem.ToString();

                    EmployeeModel model = new EmployeeModel(empSSN, empName, empPhone, empAddress, empGender, empPosition);

                    GlobalConfig.Connection.CreateEmployee(model);
                    MessageBox.Show("Employee Record Successfully Added");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            ShowEmployees();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmployeeList.SelectedRows.Count > 0)
            {
                EmpSsnTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
                EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
                EmpPhoneTb.Text = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
                EmpAddTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
                EmpGenderCb.SelectedItem = EmployeeList.SelectedRows[0].Cells[5].Value;
                EmpPositionCb.SelectedItem = EmployeeList.SelectedRows[0].Cells[6].Value;
                key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());

            }
            else
            {
                MessageBox.Show("Error Selecting Row");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpSsnTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int empId = key;
                    string empSSN = EmpSsnTb.Text;
                    string empName = EmpNameTb.Text;
                    string empPhone = EmpPhoneTb.Text;
                    string empAddress = EmpAddTb.Text;
                    string empGender = EmpGenderCb.SelectedItem.ToString();
                    string empPosition = EmpPositionCb.SelectedItem.ToString();

                    EmployeeModel model = new EmployeeModel(empId, empSSN, empName, empPhone, empAddress, empGender, empPosition);

                    GlobalConfig.Connection.UpdateEmployee(model);
                    MessageBox.Show("Employee Record Updated Successfully");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            ShowEmployees();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void EmpNameTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void EmpGenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void EmpSsnTb_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

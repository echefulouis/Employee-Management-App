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
    public partial class EmpSplash : Form
    {
        public EmpSplash()
        {
            InitializeComponent();
        }

        private void EmpSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 4;
            progressBar.Value = startpoint;
            if(progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                this.Hide();

                Login log = new Login();
                log.Show();
            }
        }
    }
}

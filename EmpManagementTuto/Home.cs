using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpManagementTuto
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
            this.Hide();
        }

        private void lblSalary_Click(object sender, EventArgs e)
        {
            Salary sl = new Salary();
            sl.Show();
            this.Hide();    
        }
    }
}

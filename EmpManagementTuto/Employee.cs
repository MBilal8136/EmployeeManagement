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
    public partial class Employee : Form
    {
        function fn = new function();
        string query;
        public Employee()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtAddress.Text != "" && txtDOB.Text != "" && txtEdu.Text != "" && txtGender.Text != "" && txtPhone.Text != "" && txtPostion.Text != "")
            {
                query = "SELECT * FROM EmployeeTB Where EmployeeID = "+txtID.Text+"";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    int id = int.Parse(txtID.Text);
                    string name = txtName.Text;
                    string address = txtAddress.Text;
                    string dob = txtDOB.Text;
                    string edu = txtEdu.Text;
                    int phone = int.Parse(txtPhone.Text);
                    string postion = txtPostion.Text;
                    string gender = txtGender.Text;


                    query = "INSERT INTO EmployeeTB VALUES(" + id + ",'" + name + "','" + address + "','" + gender + "','" + postion + "','" + dob + "','" + edu + "'," + phone + ")";
                    fn.setData(query, "Data Add Successfully");
                    load();
                    reset();
                }
                else
                {
                    MessageBox.Show("This "+txtID.Text+ " Already Exist");
                }
               
            }


        }
        private void load()
        {
            query = "SELECT * FROM EmployeeTB";
            DataSet ds = fn.getData(query);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            load();
        }

        private void reset()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtGender.SelectedIndex = -1;
            txtEdu.Text = "";
            txtPostion.SelectedIndex = -1;
            txtDOB.ResetText();
            txtAddress.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtAddress.Text != "" && txtDOB.Text != "" && txtEdu.Text != "" && txtGender.Text != "" && txtPhone.Text != "" && txtPostion.Text != "")
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string address = txtAddress.Text;
                string dob = txtDOB.Text;
                string edu = txtEdu.Text;
                int phone = int.Parse(txtPhone.Text);
                string postion = txtPostion.Text;
                string gender = txtGender.Text;


                query = "Update EmployeeTB set  Emp_Name = '" + name + "',Emp_Address = '" + address + "',Emp_Gender = '" + gender + "', Emp_Postion ='" + postion + "', Emp_DOB ='" + dob + "', Emp_Education ='" + edu + "', Emp_Phone = " + phone + " WHERE EmployeeID = "+id+" ";
                fn.setData(query, "Data Update Successfully");
                load();
                reset();
            }
        }

      
        private void bunifuCustomDataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAddress.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGender.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPostion.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDOB.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEdu.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPhone.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        int eid;
        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           eid = int.Parse( bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You want to Delete?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                query = "Delete FROM EmployeeTB where EmployeeID = "+eid+"";
                fn.setData(query, "Data Delete Successfully");
                load();
                reset();

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}

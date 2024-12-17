using System;
using System.Collections;
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
    public partial class Salary : Form
    {
        function fn = new function();
        string query;
        public Salary()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtGender.Text != "" && txtPhone.Text != "" && txtPostion.Text != "" && txtSalary.Text !="")
            {
                query = "SELECT * FROM EmployeeTB Where EmployeeID = " + txtID.Text + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    int id = int.Parse(txtID.Text);
                    string name = txtName.Text;
                    Int32 phone = Int32.Parse(txtPhone.Text);
                    string postion = txtPostion.Text;
                    string gender = txtGender.Text;
                    Int32 salary = Int32.Parse(txtSalary.Text);


                    query = "INSERT INTO SalaryTB (EmployeeID ,Emp_Name , Emp_Gender, Emp_Postion, Emp_Phone , Emp_Salary ) VALUES(" + id + ",'" + name + "','" + gender + "','" + postion + "'," + phone + " ," + salary + ")";
                    fn.setData(query, "Data Add Successfully");
                    load();
                    reset();
                }
                else
                {
                    MessageBox.Show("This " + txtID.Text + " Already Exist");
                    reset();
                }
            }


        }
        private void load()
        {
            query = "SELECT * FROM SalaryTB";
            DataSet ds = fn.getData(query);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void reset()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtGender.Text = "";
            txtSalary.Text = "";
            txtPostion.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtGender.Text != "" && txtPhone.Text != "" && txtPostion.Text != "")
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
               
                int phone = int.Parse(txtPhone.Text);
                string postion = txtPostion.Text;
                string gender = txtGender.Text;
                Int64 salary = Int64.Parse( txtSalary.Text);


                query = "Update SalaryTB set  Emp_Name = '" + name + "',Emp_Gender = '" + gender + "', Emp_Postion ='" + postion + "', Emp_Phone = " + phone + " , Emp_Salary = "+ salary + "  WHERE EmployeeID = " + id + " ";
                fn.setData(query, "Data Update Successfully");
                load();
                reset();
            }
        }


        private void bunifuCustomDataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();           
            txtGender.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPostion.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();          
            txtPhone.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSalary.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();


        }

        int eid;
        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eid = int.Parse(bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "Delete FROM EmployeeTB where EmployeeID = " + eid + "";
                fn.setData(query, "Data Delete Successfully");
                load();
                reset();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtID.Text !="")
            {
                query = "SELECT * FROM EmployeeTB where EmployeeID = " + txtID.Text + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtPostion.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtPhone.Text = ds.Tables[0].Rows[0][7].ToString();

                }
                else
                {
                    MessageBox.Show("This Employee ID not Exist");
                }
            }
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if(ch == 13)
            {
                btnSearch_Click(this, null);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            load();
        }
    }
    
}

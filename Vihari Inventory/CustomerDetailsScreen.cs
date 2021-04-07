using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Vihari_Inventory
{
    public partial class CustomerDetailsScreen : Form
    {
        private Validate objValidate;
        private Validate NewValidate()
        {
            return new Validate();
        }
        public CustomerDetailsScreen()
        {
            InitializeComponent();
            objValidate = NewValidate();
        }

        private void CustomerDetailsScreen_Load(object sender, EventArgs e)
        {
            LoadData();
            TimeandSerial();
        }
        private void TimeandSerial()
        {
            //Time And Date
            timer.Start();
            txtTime.ReadOnly = true;
            txtDate.ReadOnly = true;
            txtTime.Text = DateTime.Now.ToLongTimeString();
            txtDate.Text = DateTime.Now.ToLongDateString();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }
        public void LoadData()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Helper.Connect);
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from CustomerDT", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewCD.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewCD.Rows.Add();
                    dataGridViewCD.Rows[n].Cells[0].Value = item["CustomerCode"].ToString();
                    dataGridViewCD.Rows[n].Cells[1].Value = item["CustomerName"].ToString();
                    dataGridViewCD.Rows[n].Cells[2].Value = item["ContactNumber"].ToString();
                    dataGridViewCD.Rows[n].Cells[3].Value = item["EmailId"].ToString();
                    dataGridViewCD.Rows[n].Cells[4].Value = item["Address"].ToString();
                    dataGridViewCD.Rows[n].Cells[5].Value = item["GSTNumber"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error laoding Date", "Error");
            }
        }
        private bool CustomerCheck(TextBox textBox)
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter sda = new OleDbDataAdapter("Select * from CustomerDT where CustomerCode='" + txtCCode.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
             return true; 
            else
             return false; 
        }
    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                objValidate.EmptyBoxCheck(txtCCode) ||
                objValidate.EmptyBoxCheck(txtCName) ||
                objValidate.EmptyBoxCheck(txtCContactNumber))
                {
                    MessageBox.Show("Text box fields are mandatory and cannot be empty", "Error- Empty Fields");
                }
                else
                {
                    if (CustomerCheck(txtCCode))
                    {
                        MessageBox.Show("Cannot add Customer code '" + txtCCode.Text + "' as it already exists.", "Error");
                    }
                    else
                    {
                        OleDbConnection con = new OleDbConnection(Helper.Connect);
                        OleDbCommand cmd = new OleDbCommand("Insert into CustomerDT(CustomerCode,CustomerName,ContactNumber,EmailId,Address,GSTNumber) values ('" + txtCCode.Text + "','" + txtCName.Text + "','" + txtCContactNumber.Text + "','"+txtCEmail.Text+"','" + txtCAddress.Text + "','" + txtCGSTNumber.Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Customer details added succesfully", "Customer Added");
                        this.Close();
                        CustomerDetailsScreen s4 = new CustomerDetailsScreen();
                        s4.Show();
                    }
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (objValidate.EmptyBoxCheck(txtCCode))
                {
                    MessageBox.Show("Customer Code field is mandatory and cannot be empty", "Error-Empty Field");
                }
                else
                {
                    if (CustomerCheck(txtCCode))
                    {
                        DialogResult dig = MessageBox.Show("Do you want to modify the Supplier '" + txtCCode.Text + "' details? ", "Modify Supplier ", MessageBoxButtons.YesNo);

                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Update CustomerDT set CustomerName='" + txtCName.Text + "',ContactNumber = '" + txtCContactNumber.Text + "',EmailId='"+txtCEmail.Text+ "',Address='" + txtCAddress.Text + "',GSTNumber='" + txtCGSTNumber.Text + "' where CustomerCode = '" + txtCCode.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Updated customer details Succesfully", "Updated");
                            this.Close();
                            CustomerDetailsScreen s4 = new CustomerDetailsScreen();
                            s4.Show();
                        }
                        else
                        {
                            this.Close();
                            CustomerDetailsScreen s4 = new CustomerDetailsScreen();
                            s4.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot update customer details '" + txtCCode.Text + "' as it does not exist", "Error");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                objValidate.EmptyBoxCheck(txtCCode))
                {
                    MessageBox.Show("Customer Code field is mandatory and cannot be empty", "Error- Empty Field");
                }
                else
                {
                    if (CustomerCheck(txtCCode))
                    {
                        DialogResult dig = MessageBox.Show("Do you Want to delete the customer '" + txtCCode.Text + "' details from Database ", "Delete Product ", MessageBoxButtons.YesNo);

                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Delete from CustomerDT where CustomerCode='" + txtCCode.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Customer details deleted succesfully", "Customer Deleted");
                            this.Close();
                            CustomerDetailsScreen s4 = new CustomerDetailsScreen();
                            s4.Show();
                        }
                        else
                        {
                            this.Close();
                            CustomerDetailsScreen s4 = new CustomerDetailsScreen();
                            s4.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete customer '" + txtCCode.Text + "' details as it does not exist", "Error");

                    }
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridViewCD_Click(object sender, EventArgs e)
        {
            try
            {
                txtCCode.Text = dataGridViewCD.SelectedRows[0].Cells[0].Value.ToString();
                txtCName.Text = dataGridViewCD.SelectedRows[0].Cells[1].Value.ToString();
                txtCContactNumber.Text = dataGridViewCD.SelectedRows[0].Cells[2].Value.ToString();
                txtCEmail.Text = dataGridViewCD.SelectedRows[0].Cells[3].Value.ToString();
                txtCAddress.Text = dataGridViewCD.SelectedRows[0].Cells[4].Value.ToString();
                txtCGSTNumber.Text = dataGridViewCD.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void txtCCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtCName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '#' || e.KeyChar == ',' ||
              e.KeyChar == '-' || e.KeyChar == '/' || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtCGSTNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

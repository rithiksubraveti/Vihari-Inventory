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
    public partial class SuppliersScreen : Form
    {
        private Validate objValidate;
        private Validate NewValidate()
        {
            return new Validate();
        }
        public SuppliersScreen()
        {
            InitializeComponent();
            objValidate = NewValidate();
        }

        private void SuppliersScreen_Load(object sender, EventArgs e)
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
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from SupplierDT", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSD.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewSD.Rows.Add();
                dataGridViewSD.Rows[n].Cells[0].Value = item["SupplierCode"].ToString();
                dataGridViewSD.Rows[n].Cells[1].Value = item["SupplierName"].ToString();
                dataGridViewSD.Rows[n].Cells[2].Value = item["ContactNumber"].ToString();
                dataGridViewSD.Rows[n].Cells[3].Value = item["EmailId"].ToString();
                dataGridViewSD.Rows[n].Cells[4].Value = item["Address"].ToString();
                dataGridViewSD.Rows[n].Cells[5].Value = item["GSTNumber"].ToString();
            }
        }
        private bool SupplierCheck(TextBox textBox)
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from SupplierDT where SupplierCode='" + txtSCode.Text + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (objValidate.EmptyBoxCheck(txtSCode) ||
            objValidate.EmptyBoxCheck(txtSName) ||
            objValidate.EmptyBoxCheck(txtSContactNumber))
                {
                    MessageBox.Show("Text box fields are mandatory and cannot be empty", "Error- Empty Fields");
                }
                else
                {
                    if (SupplierCheck(txtSCode))
                    {
                        MessageBox.Show("Cannot add supplier code '" + txtSCode.Text + "' already exists.", "Error");
                    }
                    else
                    {
                        OleDbConnection con = new OleDbConnection(Helper.Connect);
                        OleDbCommand cmd = new OleDbCommand("Insert into SupplierDT(SupplierCode,SupplierName,ContactNumber,EmailId,Address,GSTNumber) values ('" + txtSCode.Text + "','" + txtSName.Text + "'," + txtSContactNumber.Text + ",'"+txtSEmail.Text+"','" + txtSAddress.Text + "','" + txtSGSTNumber.Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Supplier details added succesfully", "Supplier Added");
                        this.Close();
                        SuppliersScreen s3 = new SuppliersScreen();
                        s3.Show();
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
                if (objValidate.EmptyBoxCheck(txtSCode))
                {
                    MessageBox.Show("Supplier Code field is mandatory and cannot be empty", "Error- Empty Fields");
                }
                else
                {
                    if (SupplierCheck(txtSCode))
                    {
                        DialogResult dig = MessageBox.Show("Do you want to modify the Supplier '" + txtSCode.Text + "' details? ", "Modify Supplier ", MessageBoxButtons.YesNo);

                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Update SupplierDT set SupplierName='" + txtSName.Text + "',ContactNumber = '" + txtSContactNumber.Text + "',EmailId='"+txtSEmail.Text+"',Address='" + txtSAddress.Text + "',GSTNumber='" + txtSGSTNumber.Text + "' where SupplierCode = '" + txtSCode.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Updated supplier details Succesfully.", "Supplier Updated");
                            this.Close();
                            SuppliersScreen s3 = new SuppliersScreen();
                            s3.Show();
                        }
                        else
                        {
                            this.Close();
                            SuppliersScreen s3 = new SuppliersScreen();
                            s3.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot update supplier details as '" + txtSCode.Text + "' does not exist.", "Error");
                    }
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (objValidate.EmptyBoxCheck(txtSCode))
                {
                    MessageBox.Show("Supplier Code field is mandatory and cannot be empty", "Error- Empty Fields");
                }
                else
                {
                    if (SupplierCheck(txtSCode))
                    {
                        DialogResult dig = MessageBox.Show("Do you want to delete the supplier '" + txtSCode.Text + "' details from Database.", "Delete Product ", MessageBoxButtons.YesNo);
                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Delete from SupplierDT where SupplierCode='" + txtSCode.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Supplier details deleted succesfully.", "Supplier Deleted");
                            this.Close();
                            SuppliersScreen s3 = new SuppliersScreen();
                            s3.Show();
                        }
                        else
                        {
                            this.Close();
                            SuppliersScreen s3 = new SuppliersScreen();
                            s3.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete supplier details as '" + txtSCode.Text + "'  does not exist.", "Error");
                    }
                }
            }
            catch (Exception x)
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

        private void dataGridViewSD_Click(object sender, EventArgs e)
        {
            try
            {
                txtSCode.Text = dataGridViewSD.SelectedRows[0].Cells[0].Value.ToString();
                txtSName.Text = dataGridViewSD.SelectedRows[0].Cells[1].Value.ToString();
                txtSContactNumber.Text = dataGridViewSD.SelectedRows[0].Cells[2].Value.ToString();
                txtSEmail.Text = dataGridViewSD.SelectedRows[0].Cells[3].Value.ToString();
                txtSAddress.Text = dataGridViewSD.SelectedRows[0].Cells[4].Value.ToString();
                txtSGSTNumber.Text = dataGridViewSD.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void txtSContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtSName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtSAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '#' || e.KeyChar == ',' ||
               e.KeyChar == '-' || e.KeyChar == '/' || char.IsDigit(e.KeyChar)|| e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtSGSTNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtSCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

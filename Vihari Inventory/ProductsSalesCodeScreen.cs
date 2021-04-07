using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vihari_Inventory
{
    public partial class ProductsSalesCodeScreen : Form
    {
        private Validate objValidate;
        private Validate NewValidate()
        {
            return new Validate();
        }
        public ProductsSalesCodeScreen()
        {
            InitializeComponent();
            objValidate = NewValidate();
        }
        private void ProductsSalesCodeScreen_Load(object sender, EventArgs e)
        {
            TimeandSerial();
            dataGridViewPSC.AutoResizeColumns();
            dataGridViewPSC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadData();
        }
        private void TimeandSerial()
        {  //Time And Date
            timer.Start();
            txtPSCTime.ReadOnly = true;
            txtPSCDate.ReadOnly = true;
            txtPSCTime.Text = DateTime.Now.ToLongTimeString();
            txtPSCDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtPSCTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }
        public void LoadData()
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from ProductSaleCodeDT", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPSC.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewPSC.Rows.Add();
                dataGridViewPSC.Rows[n].Cells[0].Value = item["ProductSaleCode"].ToString();
                dataGridViewPSC.Rows[n].Cells[1].Value = item["ProductSaleDescription"].ToString();
                dataGridViewPSC.Rows[n].Cells[2].Value = item["ProductSaleRate"].ToString();
            }
        }
        private bool ProductCheck(TextBox textBox)
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from ProductSaleCodeDT where ProductSaleCode='" + txtPSCCode.Text + "' ", con);
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
                if (objValidate.EmptyBoxCheck(txtPSCCode) || objValidate.EmptyBoxCheck(txtPSCDescription))
                {
                    MessageBox.Show("Text box fields are mandatory and cannot be empty", "Error- Empty Fields");
                }
                else
                {
                    if (ProductCheck(txtPSCCode))
                    {
                        MessageBox.Show("Cannot ADD product as Product Code '" + txtPSCCode.Text + "' Already Exists", "Error");

                    }
                    else
                    {
                        OleDbConnection con = new OleDbConnection(Helper.Connect);
                        OleDbCommand cmd = new OleDbCommand("Insert into ProductSaleCodeDT(ProductSaleCode,ProductSaleDescription,ProductSaleRate) values ('" + txtPSCCode.Text + "','" + txtPSCDescription.Text + "','" + txtPSCRate.Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product Added Succesfully", "Product Added");
                        this.Close();
                        //LoadData();
                        ProductsSalesCodeScreen s2 = new ProductsSalesCodeScreen();
                        s2.Show();
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
                if (objValidate.EmptyBoxCheck(txtPSCCode))
                {
                    MessageBox.Show("Product Sales Code field cannot be empty", "Error-Empty Field");
                }
                else
                {
                    if (ProductCheck(txtPSCCode))
                    {
                        DialogResult dig = MessageBox.Show("Do you want to modify the product '" + txtPSCCode.Text + "' details? ", "Modify Product ", MessageBoxButtons.YesNo);
                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Update ProductSaleCodeDT set ProductSaleDescription='" + txtPSCDescription.Text + "',ProductSaleRate = '" + txtPSCRate.Text + "' where ProductSaleCode = '" + txtPSCCode.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Modified Product Succesfully", "Product Modified");
                            this.Close();
                            ProductsSalesCodeScreen s2 = new ProductsSalesCodeScreen();
                            s2.Show();
                        }
                        else
                        {
                            this.Close();
                            ProductsSalesCodeScreen s2 = new ProductsSalesCodeScreen();
                            s2.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot update product as Product Code '" + txtPSCCode.Text + "' does not Exists", "Error");
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
                if (objValidate.EmptyBoxCheck(txtPSCCode))
                {
                    MessageBox.Show("Product Sales Code field cannot be empty", "Error-Empty Field");
                }
                else
                {
                    if (ProductCheck(txtPSCCode))
                    {
                        DialogResult dig = MessageBox.Show("Do you Want to delete the product '" + txtPSCCode.Text + "' from Database ", "Delete Product ", MessageBoxButtons.YesNo);
                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Delete ProductSaleCodeDT where ProductSaleCode='" + txtPSCCode.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Product Deleted Succesfully", "Product Deleted");
                            this.Close();
                            ProductsSalesCodeScreen s2 = new ProductsSalesCodeScreen();
                            s2.Show();
                        }
                        else
                        {
                            this.Close();
                            ProductsSalesCodeScreen s2 = new ProductsSalesCodeScreen();
                            s2.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete product as Product Code '" + txtPSCCode.Text + "' does not exist", "Error");
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

        private void dataGridViewPSC_Click(object sender, EventArgs e)
        {
            try
            {
                txtPSCCode.Text = dataGridViewPSC.SelectedRows[0].Cells[0].Value.ToString();
                txtPSCDescription.Text = dataGridViewPSC.SelectedRows[0].Cells[1].Value.ToString();
                txtPSCRate.Text = dataGridViewPSC.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        
        private void txtPSCCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtPSCDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtPSCRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

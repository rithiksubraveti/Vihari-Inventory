using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class ProductsMasterScreen : Form
    {
        private Validate objValidate;
        private Validate NewValidate()
        {
            return new Validate();

        }
        public ProductsMasterScreen()
        {
            InitializeComponent();
            objValidate = NewValidate();

        }

        private void ProductsMasterScreen_Load(object sender, EventArgs e)
        {
            TimeandSerial();
            dataGridViewPM.AutoResizeColumns();
            dataGridViewPM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadData();
        }
        private void TimeandSerial()
        {
            //Time And Date
            timer.Start();
            txtPMTime.ReadOnly = true;
            txtPMDate.ReadOnly = true;
            txtPMTime.Text = DateTime.Now.ToLongTimeString();
            txtPMDate.Text = DateTime.Now.ToLongDateString();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            txtPMTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }
        public void LoadData()
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbCommand cmd = new OleDbCommand("Select * from ProductMasterDT", con);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPM.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewPM.Rows.Add();
                dataGridViewPM.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridViewPM.Rows[n].Cells[1].Value = item["ProductDescription"].ToString();
                dataGridViewPM.Rows[n].Cells[2].Value = item["ProductRate"].ToString();
                dataGridViewPM.Rows[n].Cells[3].Value = item["UnitOfMeasurement"].ToString();
                dataGridViewPM.Rows[n].Cells[4].Value = item["QuantityOnHand"].ToString();
            }
        }
        private bool ProductCheck(TextBox textBox)
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from ProductMasterDT where ProductCode='" + txtPMCode.Text + "' ", con);
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
                if (
               objValidate.EmptyBoxCheck(txtPMCode) ||
               objValidate.EmptyBoxCheck(txtPMDescription) ||
               objValidate.EmptyBoxCheck(txtPMRate))
                {
                    MessageBox.Show("Text box fields are mandatory and cannot be empty", "Error- Empty Fields");
                }
                else
                {
                    if (ProductCheck(txtPMCode))
                    {
                        MessageBox.Show("Cannot ADD product as Product Code '" + txtPMCode.Text + "' Already Exists", "Error");

                    }
                    else
                    {
                        OleDbConnection con = new OleDbConnection(Helper.Connect);
                        OleDbCommand cmd = new OleDbCommand("Insert into ProductMasterDT(ProductCode,ProductDescription,ProductRate,UnitOfMeasurement,QuantityOnHand) values ('" + txtPMCode.Text + "','" + txtPMDescription.Text + "'," + txtPMRate.Text + ",'" + txtPMUOM.Text + "','" + txtPMQOH.Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product Added Succesfully", "Product Added");
                        this.Close();
                        ProductsMasterScreen s1 = new ProductsMasterScreen();
                        s1.Show();
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
                if (objValidate.EmptyBoxCheck(txtPMCode))
                {
                    MessageBox.Show("Product Code field is mandatory and cannot be empty", "Error- Empty Fields");
                }
                else
                {
                    if (ProductCheck(txtPMCode))
                    {
                        DialogResult dig = MessageBox.Show("Do you want to modify the product '" + txtPMCode.Text + "' details? ", "Modify Product ", MessageBoxButtons.YesNo);

                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Update ProductMasterDT set ProductDescription='" + txtPMDescription.Text + "',ProductRate = '" + txtPMRate.Text + "',QuantityOnHand='"+txtPMQOH.Text+"' where ProductCode = '" + txtPMCode.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Modified Product Succesfully", "Product Modified");
                            this.Close();
                            ProductsMasterScreen s1 = new ProductsMasterScreen();
                            s1.Show();
                        }
                        else
                        {
                            this.Close();
                            ProductsMasterScreen s1 = new ProductsMasterScreen();
                            s1.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No product with name '" + txtPMCode.Text + "' exists.", "Error");
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
                if (objValidate.EmptyBoxCheck(txtPMCode))
                {
                    MessageBox.Show("Product Code field is mandatory and cannot be empty", "Error- Empty Fields");
                }
                else
                {
                    if (ProductCheck(txtPMCode))
                    {
                        DialogResult dig = MessageBox.Show("Do you Want to delete the product '" + txtPMCode.Text + "' from Database ", "Delete Product ", MessageBoxButtons.YesNo);
                        if (dig == DialogResult.Yes)
                        {

                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Delete from ProductMasterDT where ProductCode='" + txtPMCode.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Product Deleted Succesfully", "Product Deleted");
                            this.Close();
                            ProductsMasterScreen s1 = new ProductsMasterScreen();
                            s1.Show();
                        }
                        else
                        {
                            this.Close();
                            ProductsMasterScreen s1 = new ProductsMasterScreen();
                            s1.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot Delete product as Product Code '" + txtPMCode.Text + "' does not Exists", "Error");
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
       
        private void dataGridViewPM_Click(object sender, EventArgs e)
        {
            try
            {
                txtPMCode.Text = dataGridViewPM.SelectedRows[0].Cells[0].Value.ToString();
                txtPMDescription.Text = dataGridViewPM.SelectedRows[0].Cells[1].Value.ToString();
                txtPMRate.Text = dataGridViewPM.SelectedRows[0].Cells[2].Value.ToString();
                txtPMUOM.Text = dataGridViewPM.SelectedRows[0].Cells[3].Value.ToString();
                txtPMQOH.Text = dataGridViewPM.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void txtPMCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtPMDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtPMRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtPMUOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtPMQOH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

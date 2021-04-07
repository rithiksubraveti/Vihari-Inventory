using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Vihari_Inventory
{
    public partial class MaterialMasterScreen : Form
    {
        private Validate objValidate;
        private Validate NewValidate()
        {
            return new Validate();
        }
        public MaterialMasterScreen()
        {
            InitializeComponent();
            objValidate = NewValidate();
        }

        private void MaterialMasterScreen_Load(object sender, EventArgs e)
        {
            TimeandSerial();
            dataGridViewMM.AutoResizeColumns();
            dataGridViewMM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadData();
        }
        private void TimeandSerial()
        {
            timer.Start();
            txtTime.ReadOnly = true;
            txtDate.ReadOnly = true;
            txtTime.Text = DateTime.Now.ToLongTimeString();
            txtDate.Text = DateTime.Now.ToLongDateString();
        }
        public void LoadData()
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbCommand cmd = new OleDbCommand("Select * from MaterialMasterDT", con);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMM.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewMM.Rows.Add();
                dataGridViewMM.Rows[n].Cells[0].Value = item["MaterialCode"].ToString();
                dataGridViewMM.Rows[n].Cells[1].Value = item["MaterialDescription"].ToString();
                dataGridViewMM.Rows[n].Cells[2].Value = item["QuantityOnHand"].ToString();
            }
        }
        private bool ProductCheck(TextBox textBox)
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from MaterialMasterDT where MaterialCode='" + txtMMCode.Text + "' ", con);
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
                    if (objValidate.EmptyBoxCheck(txtMMCode) ||
                   objValidate.EmptyBoxCheck(txtMMDescription))
                    {
                        MessageBox.Show("Text box fields are mandatory and cannot be empty", "Error- Empty Fields");
                    }
                    else
                    {
                        if (ProductCheck(txtMMCode))
                        {
                            MessageBox.Show("Cannot ADD Material as Material Code '" + txtMMCode.Text + "' already Exists", "Error");
                        }
                        else
                        {
                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Insert into MaterialMasterDT(MaterialCode,MaterialDescription,QuantityOnHand) values ('" + txtMMCode.Text + "','" + txtMMDescription.Text + "','" + txtMMQOH.Text + "')", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Material Added Succesfully", "Material Added");
                            this.Close();
                            MaterialMasterScreen s1 = new MaterialMasterScreen();
                            s1.Show();
                        }
                    }
           }
           catch (Exception x)
           {
               MessageBox.Show(x.Message);
           }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (objValidate.EmptyBoxCheck(txtMMCode))
                {
                    MessageBox.Show("Material Code field is mandatory and cannot be empty", "Error- Empty Fields");
                }
                else
                {
                    if (ProductCheck(txtMMCode))
                    {
                        DialogResult dig = MessageBox.Show("Do you want to modify the material '" + txtMMCode.Text + "' details? ", "Modify Material ", MessageBoxButtons.YesNo);

                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Update MaterialMaster set MaterialDescription='" + txtMMDescription.Text +"',QuantityOnHand='" + txtMMQOH.Text + "' where MaterialCode = '" + txtMMCode.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Modified material succesfully", "Material Modified");
                            this.Close();
                            MaterialMasterScreen s1 = new MaterialMasterScreen();
                            s1.Show();
                        }
                        else
                        {
                            this.Close();
                            MaterialMasterScreen s1 = new MaterialMasterScreen();
                            s1.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No material with name '" + txtMMCode.Text + "' exists.", "Error");
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (objValidate.EmptyBoxCheck(txtMMCode))
                {
                    MessageBox.Show("Product Code field is mandatory and cannot be empty", "Error- Empty Fields");
                }
                else
                {
                    if (ProductCheck(txtMMCode))
                    {
                        DialogResult dig = MessageBox.Show("Do you Want to delete the material '" + txtMMCode.Text + "' from Database ", "Delete Material ", MessageBoxButtons.YesNo);
                        if (dig == DialogResult.Yes)
                        {

                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Delete from MaterialMasterDT where MaterialCode='" + txtMMCode.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Material Deleted Succesfully", "Material Deleted");
                            this.Close();
                            MaterialMasterScreen s1 = new MaterialMasterScreen();
                            s1.Show();
                        }
                        else
                        {
                            this.Close();
                            MaterialMasterScreen s1 = new MaterialMasterScreen();
                            s1.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot Delete material as Material Code '" + txtMMCode.Text + "' does not Exists", "Error");
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

        private void dataGridViewMM_Click(object sender, EventArgs e)
        {
            try
            {
                txtMMCode.Text = dataGridViewMM.SelectedRows[0].Cells[0].Value.ToString();
                txtMMDescription.Text = dataGridViewMM.SelectedRows[0].Cells[1].Value.ToString();
                txtMMQOH.Text = dataGridViewMM.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void txtMMCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtMMDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtMMQOH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

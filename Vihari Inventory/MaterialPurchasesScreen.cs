using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vihari_Inventory
{
    public partial class MaterialPurchasesScreen : Form
    {
        double q, q1, q2, qf, qf1;

        private Validate objValidate;
        private Validate NewValidate()
        {
            return new Validate();
        }
        public MaterialPurchasesScreen()
        {
            InitializeComponent();
            objValidate = NewValidate();
        }

        private void MaterialPurchasesScreen_Load(object sender, EventArgs e)
        {
            TimeandSerial();
            dataGridViewM.AutoResizeColumns();
            dataGridViewM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadData();
            ComboFill();
        }

        private void TimeandSerial()
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter da = new OleDbDataAdapter("Select isnull (max(cast(GoodsReceiptNumber as int)),300000)+1 from MaterialPurchaseDT", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtPRN.Text = dt.Rows[0][0].ToString();
            //Time And Date
            timer.Start();
            txtMTime.ReadOnly = true;
            txtMDate.ReadOnly = true;
            txtMTime.Text = DateTime.Now.ToLongTimeString();
            txtMDate.Text = DateTime.Now.ToLongDateString();
        }

        
        private void timer_Tick(object sender, EventArgs e)
        {
            txtMTime.Text = DateTime.Now.ToLongTimeString();
            //txtPDate.Text = DateTime.Now.ToLongDateString();
            timer.Start();
        }
        public void LoadData()
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter sda = new OleDbDataAdapter("Select * from MaterialPurchaseDT order by  GoodsReceiptNumber DESC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewM.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewM.Rows.Add();
                dataGridViewM.Rows[n].Cells[0].Value = item["MDate"].ToString();
                dataGridViewM.Rows[n].Cells[1].Value = item["GoodsReceiptNumber"].ToString();
                dataGridViewM.Rows[n].Cells[2].Value = item["SupplierCode"].ToString();
                dataGridViewM.Rows[n].Cells[3].Value = item["SupplierName"].ToString();
                dataGridViewM.Rows[n].Cells[4].Value = item["MaterialCode"].ToString();
                dataGridViewM.Rows[n].Cells[5].Value = item["MaterialDescription"].ToString();
                dataGridViewM.Rows[n].Cells[6].Value = item["Quantity"].ToString();
            }
        }

        void ComboFill()
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbCommand cmd = new OleDbCommand("Select * from SupplierDT", con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbMSC.Items.Add(dr["SupplierCode"].ToString());
                cmbMSN.Items.Add(dr["SupplierName"].ToString());
            }
            dr.Close();
            con.Close();

            OleDbConnection con1 = new OleDbConnection(Helper.Connect);
            OleDbCommand cmd1 = new OleDbCommand("Select * from MaterialMasterDT", con1);
            con1.Open();
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                cmbMC.Items.Add(dr1["MaterialCode"].ToString());
                cmbMD.Items.Add(dr1["MaterialDescription"].ToString());
            }
            dr1.Close();
            con1.Close();
        }

        private bool ReceiptNumberCheck(TextBox textBox)
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter sda = new OleDbDataAdapter("Select * from MaterialPurchaseDT where GoodsReceiptNumber=" + txtPRN.Text + "", con);
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
                if (objValidate.EmptyComboBoxCheck(cmbMSC) || objValidate.EmptyComboBoxCheck(cmbMC) || objValidate.EmptyComboBoxCheck(cmbMD)||
                     objValidate.EmptyComboBoxCheck(cmbMSN) || objValidate.EmptyBoxCheck(txtMQ))
                {
                    MessageBox.Show("Fields cannot be empty, fill text boxes and try.", "Error- Empty Fields");
                }
                else
                {
                    OleDbConnection con = new OleDbConnection(Helper.Connect);
                    OleDbCommand cmd = new OleDbCommand("Insert into MaterialPurchaseDT(MDate,MTime,GoodsReceiptNumber,SupplierCode,SupplierName,MaterialCode,MaterialDescription,Quantity) values ('" + txtMDate.Text + "','" + txtMTime.Text + "',"+txtPRN.Text+",'" + cmbMSC.Text + "','" + cmbMSN.Text + "','" + cmbMC.Text + "','" + cmbMD.Text + "'," + txtMQ.Text + ")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MaterialPurchasesScreen s5 = new MaterialPurchasesScreen();
                    s5.Show();
                    OleDbConnection con1 = new OleDbConnection(Helper.Connect);
                    OleDbCommand cmd1 = new OleDbCommand("Select * from MaterialMaster where MaterialCode='" + cmbMC.Text + "'", con1);
                    OleDbCommand cmd2 = new OleDbCommand("Update MaterialMasterDT set QuantityOnHand = @UpdatedQuantity where MaterialCode='" + cmbMC.Text + "'", con1);
                    con1.Open();
                    OleDbDataReader dr = cmd1.ExecuteReader();
                    while (dr.Read())
                    {
                        q = (Double)dr["QuantityOnHand"];
                        q1 = int.Parse(txtMQ.Text);
                        qf = q + q1;
                        cmd2.Parameters.AddWithValue("@UpdatedQuantity", qf);
                    }
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    con1.Close();
                    MessageBox.Show("Purchase details saved Succesfully", "Purchase Saved");
                    this.Close();
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
                if (objValidate.EmptyComboBoxCheck(cmbMC) || objValidate.EmptyComboBoxCheck(cmbMD) ||
                    objValidate.EmptyComboBoxCheck(cmbMSC) || objValidate.EmptyComboBoxCheck(cmbMSN) ||
                    objValidate.EmptyBoxCheck(txtMQ))
                {
                    MessageBox.Show("Fields cannot be empty, fill text boxes and try.", "Error- Empty Fields");
                }
                else
                {
                    if (ReceiptNumberCheck(txtPRN))
                    {
                            DialogResult dig = MessageBox.Show("Do you want to modify '" + cmbMC.Text + "' details? ", "Modify details ", MessageBoxButtons.YesNo);
                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con1 = new OleDbConnection(Helper.Connect);
                            OleDbConnection con2 = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd1 = new OleDbCommand("Select * from MaterialMasterDT where MaterialCode='" + cmbMC.Text + "'", con1);
                            OleDbCommand cmd3 = new OleDbCommand("Select * from MaterialPurchaseDT where MaterialCode='" + cmbMC.Text + "' and GoodsReceiptNumber=" + txtPRN.Text + "", con1);
                            OleDbCommand cmd2 = new OleDbCommand("Update MaterialMasterDT set QuantityOnHand = @UpdatedQuantity where MaterialCode='" + cmbMC.Text + "'", con2);
                            con1.Open();
                            OleDbDataReader dr = cmd1.ExecuteReader();
                            while (dr.Read())
                            {
                                q = (Double)dr["QuantityOnHand"];
                            }
                            dr.Close();
                            con2.Open();
                            OleDbDataReader dr1 = cmd3.ExecuteReader();
                            while (dr1.Read())
                            {
                                q1 = (Double)dr1["Quantity"];
                                q2 = int.Parse(txtMQ.Text);
                            }
                            if (q1 >= q2)
                            {
                                qf = q1 - q2;
                                if (qf < q)
                                {
                                    qf1 = q - qf;
                                    cmd2.Parameters.AddWithValue("@UpdatedQuantity", qf1);
                                }
                                else
                                {
                                    MessageBox.Show("Cannot Update Stock Quantity", "Error");
                                }
                            }
                            else
                            {
                                qf = q2 - q1;
                                qf1 = q + qf;
                                cmd2.Parameters.AddWithValue("@UpdatedQuantity", qf1);
                            }
                            //cmd2.Parameters.AddWithValue("@UpdatedQuantity", qf1);
                            dr1.Close();
                            cmd2.ExecuteNonQuery();
                            con1.Close();
                            con2.Close();

                            OleDbConnection con = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd = new OleDbCommand("Update MaterialPurchaseDT set SupplierCode='" + cmbMSC.Text + "',SupplierName='" + cmbMSN.Text + "',MaterialCode='" + cmbMC.Text + "',MaterialDescription='" + cmbMD.Text + "',Quantity= " + txtMQ.Text + " where GoodsReceiptNumber = " + txtPRN.Text + "", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Modified purchase details Succesfully", "Purchase Updated");
                            this.Close();
                            MaterialPurchasesScreen s5 = new MaterialPurchasesScreen();
                            s5.Show();
                    }
                    else
                    {
                        this.Close();
                        MaterialPurchasesScreen s5 = new MaterialPurchasesScreen();
                        s5.Show();
                    }
                }
                    
                    else
                    {
                        MessageBox.Show("Invalid Receipt number, please check the receipt number.", "Error");
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
                if (objValidate.EmptyComboBoxCheck(cmbMSC) || objValidate.EmptyComboBoxCheck(cmbMSN) || objValidate.EmptyComboBoxCheck(cmbMD) ||
                    objValidate.EmptyComboBoxCheck(cmbMC))
                {
                    MessageBox.Show("Fields cannot be empty, fill text boxes and try.", "Error- Empty Fields");
                }
                else
                {
                    txtMQ.ReadOnly = true;
                    if (ReceiptNumberCheck(txtPRN))
                    {
                        DialogResult dig = MessageBox.Show("Do you Want to delete the material '" + cmbMC.Text + "' details from Database ", "Delete Material ", MessageBoxButtons.YesNo);
                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con1 = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd1 = new OleDbCommand("Select * from MaterialMasterDT where MaterialCode='" + cmbMC.Text + "'", con1);
                            OleDbCommand cmd2 = new OleDbCommand("Update MaterialMasterDT set QuantityOnHand = @UpdatedQuantity where MaterialCode='" + cmbMC.Text + "'", con1);
                            con1.Open();
                            OleDbDataReader dr = cmd1.ExecuteReader();
                            while (dr.Read())
                            {
                                q = (Double)dr["QuantityOnHand"];
                                q1 = int.Parse(txtMQ.Text);
                            }
                            if (q > q1)
                            {
                                qf = q - q1;
                                cmd2.Parameters.AddWithValue("@UpdatedQuantity", qf);
                                OleDbConnection con = new OleDbConnection(Helper.Connect);
                                OleDbCommand cmd = new OleDbCommand("Delete from MaterialPurchaseDT where GoodsReceiptNumber=" + txtPRN.Text + "", con);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Purchase details deleted Succesfully", "Deleted");
                                this.Close();
                                PurchasesScreen s5 = new PurchasesScreen();
                                s5.Show();
                            }
                            else
                            {
                                MessageBox.Show("Cannot Delete quantity ", "Error");
                                cmd2.Parameters.AddWithValue("@UpdatedQuantity", q);
                            }
                            dr.Close();
                            cmd2.ExecuteNonQuery();
                            con1.Close();
                        }
                        else
                        {
                            this.Close();
                            MaterialPurchasesScreen s5 = new MaterialPurchasesScreen();
                            s5.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Receipt Number, please re-check Invoice number", "Error");
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
      
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void dataGridViewP_Click(object sender, EventArgs e)
        {
            try
            {
                txtPRN.Text = dataGridViewM.SelectedRows[0].Cells[1].Value.ToString();
                cmbMSC.Text = dataGridViewM.SelectedRows[0].Cells[2].Value.ToString();
                cmbMSN.Text = dataGridViewM.SelectedRows[0].Cells[3].Value.ToString();
                cmbMC.Text = dataGridViewM.SelectedRows[0].Cells[4].Value.ToString();
                cmbMD.Text = dataGridViewM.SelectedRows[0].Cells[5].Value.ToString();
                txtMQ.Text = dataGridViewM.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void cmbMSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Helper.Connect);
                OleDbDataAdapter da = new OleDbDataAdapter("Select SupplierName from SupplierDT where SupplierCode='" + cmbMSC.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmbMSN.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    cmbMSN.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbMC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Helper.Connect);
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select MaterialDescription from MaterialMasterDT where MaterialCode='" + cmbMC.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmbMD.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    cmbMD.Text = "";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void cmbMSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void cmbMSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar)|| e.KeyChar == (char)Keys.Back);
        }
        private void cmbMC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void cmbMD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtMQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !( char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

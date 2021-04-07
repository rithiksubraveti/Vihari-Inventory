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
    public partial class PurchasesScreen : Form
    {
        double q, q1, q2, qf, qf1;

        private Validate objValidate;
        private Validate NewValidate()
        {
            return new Validate();
        }
        public PurchasesScreen()
        {
            InitializeComponent();
            objValidate = NewValidate();
        }

        private void PurchasesScreen_Load(object sender, EventArgs e)
        {
            TimeandSerial();
            dataGridViewP.AutoResizeColumns();
            dataGridViewP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadData();
            ComboFill();
        }
        private void TimeandSerial()
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter da = new OleDbDataAdapter("Select isnull (max(cast(GoodsReceiptNumber as int)),100000)+1 from ProductPurchaseDT", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtPRN.Text = dt.Rows[0][0].ToString();

            //Time And Date
            timer.Start();
            txtPTime.ReadOnly = true;
            txtPDate.ReadOnly = true;
            txtPTime.Text = DateTime.Now.ToLongTimeString();
            txtPDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtPTime.Text = DateTime.Now.ToLongTimeString();
            //txtPDate.Text = DateTime.Now.ToLongDateString();
            timer.Start();
        }

        public void LoadData()
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter sda = new OleDbDataAdapter("Select * from ProductPurchaseDT order by  GoodsReceiptNumber DESC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewP.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewP.Rows.Add();
                dataGridViewP.Rows[n].Cells[0].Value = item["PDate"].ToString();
                dataGridViewP.Rows[n].Cells[1].Value = item["GoodsReceiptNumber"].ToString();
                dataGridViewP.Rows[n].Cells[2].Value = item["SupplierCode"].ToString();
                dataGridViewP.Rows[n].Cells[3].Value = item["SupplierName"].ToString();
                dataGridViewP.Rows[n].Cells[4].Value = item["SupplierInvoiceNumber"].ToString();
                dataGridViewP.Rows[n].Cells[5].Value = item["ProductCode"].ToString();
                dataGridViewP.Rows[n].Cells[6].Value = item["ProductDescription"].ToString();
                dataGridViewP.Rows[n].Cells[7].Value = item["QuantityReceived"].ToString();
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
                cmbPSC.Items.Add(dr["SupplierCode"].ToString());
                cmbPSN.Items.Add(dr["SupplierName"].ToString());
            }
            dr.Close();
            con.Close();

            OleDbConnection con1 = new OleDbConnection(Helper.Connect);
            OleDbCommand cmd1 = new OleDbCommand("Select * from ProductMasterDT", con1);
            con1.Open();
            //con.Close();
            //con.Open();
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                cmbPPC.Items.Add(dr1["ProductCode"].ToString());
                cmbPD.Items.Add(dr1["ProductDescription"].ToString());
            }
            dr1.Close();
            con1.Close();
        }
        private bool ReceiptNumberCheck(TextBox textBox)
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter sda = new OleDbDataAdapter("Select * from ProductPurchaseDT where GoodsReceiptNumber=" + txtPRN.Text + "", con);
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
                if (objValidate.EmptyComboBoxCheck(cmbPSC) || objValidate.EmptyComboBoxCheck(cmbPPC) || objValidate.EmptyComboBoxCheck(cmbPD) ||
                    objValidate.EmptyComboBoxCheck(cmbPSC) || objValidate.EmptyComboBoxCheck(cmbPSN) || objValidate.EmptyBoxCheck(txtPSI) ||
                    objValidate.EmptyBoxCheck(txtPQ))
                {
                    MessageBox.Show("Fields cannot be empty, fill text boxes and try.", "Error- Empty Fields");
                }
                else
                {
                    OleDbConnection con = new OleDbConnection(Helper.Connect);
                    OleDbCommand cmd = new OleDbCommand("Insert into ProductPurchaseDT(PDate,PTime,GoodsReceiptNumber,SupplierCode,SupplierName,SupplierInvoiceNumber,ProductCode,ProductDescription,QuantityReceived,UnitOfMeasurement) values ('" + txtPDate.Text + "','" + txtPTime.Text + "'," + txtPRN.Text + ",'" + cmbPSC.Text + "','"+cmbPSN.Text+"','" + txtPSI.Text + "','" + cmbPPC.Text + "','" + cmbPD.Text + "'," + txtPQ.Text + ",'" + txtUOM.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    PurchasesScreen s5 = new PurchasesScreen();
                    s5.Show();
                    OleDbConnection con1 = new OleDbConnection(Helper.Connect);
                    OleDbCommand cmd1 = new OleDbCommand("Select * from ProductMasterDT where ProductCode='" + cmbPPC.Text + "'", con1);
                    OleDbCommand cmd2 = new OleDbCommand("Update ProductMasterDT set QuantityOnHand = @UpdatedQuantity where ProductCode='" + cmbPPC.Text + "'", con1);
                    con1.Open();
                    OleDbDataReader dr = cmd1.ExecuteReader();
                    while (dr.Read())
                    {
                        q = (Double)dr["QuantityOnHand"];
                        q1 = int.Parse(txtPQ.Text);
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
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (objValidate.EmptyComboBoxCheck(cmbPSC) || objValidate.EmptyComboBoxCheck(cmbPPC) || objValidate.EmptyComboBoxCheck(cmbPD) ||
                    objValidate.EmptyComboBoxCheck(cmbPSC) || objValidate.EmptyComboBoxCheck(cmbPSN) ||
                    objValidate.EmptyBoxCheck(txtPQ) || objValidate.EmptyBoxCheck(txtPSI))
                {
                    MessageBox.Show("Fields cannot be empty, fill text boxes and try.", "Error- Empty Fields");
                }
                else
                {
                    if (ReceiptNumberCheck(txtPRN))
                    {
                        DialogResult dig = MessageBox.Show("Do you want to modify '" + cmbPPC.Text + "' details? ", "Modify details ", MessageBoxButtons.YesNo);
                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con1 = new OleDbConnection(Helper.Connect);
                            OleDbConnection con2 = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd1 = new OleDbCommand("Select * from ProductMasterDT where ProductCode='" + cmbPPC.Text + "'", con1);
                            OleDbCommand cmd3 = new OleDbCommand("Select * from ProductPurchaseDT where ProductCode='" + cmbPPC.Text + "' and GoodsReceiptNumber=" + txtPRN.Text + "", con1);
                            OleDbCommand cmd2 = new OleDbCommand("Update ProductMasterDT set QuantityOnHand = @UpdatedQuantity where ProductCode='" + cmbPPC.Text + "'", con2);
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
                                q1 = (Double)dr1["QuantityReceived"];
                                q2 = int.Parse(txtPQ.Text);
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
                            OleDbCommand cmd = new OleDbCommand("Update ProductPurchaseDT set SupplierCode='" + cmbPSC.Text + "',SupplierName='"+cmbPSN.Text+"',SupplierInvoiceNumber='" + txtPSI.Text + "',ProductCode='" + cmbPPC.Text + "',ProductDescription='" + cmbPD.Text + "',QuantityReceived = " + txtPQ.Text + ",UnitOfMeasurement='" + txtUOM.Text + "' where GoodsReceiptNumber = " + txtPRN.Text + "", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Modified purchase details Succesfully", "Purchase Updated");
                            this.Close();
                            PurchasesScreen s5 = new PurchasesScreen();
                            s5.Show();
                        }
                        else
                        {
                            this.Close();
                            PurchasesScreen s5 = new PurchasesScreen();
                            s5.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Receipt number, please check the receipt number.", "Error");
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
                if (objValidate.EmptyComboBoxCheck(cmbPSC) || objValidate.EmptyComboBoxCheck(cmbPPC) || objValidate.EmptyComboBoxCheck(cmbPD) ||
                    objValidate.EmptyComboBoxCheck(cmbPSC) || objValidate.EmptyComboBoxCheck(cmbPSN) ||
                    objValidate.EmptyBoxCheck(txtPQ) || objValidate.EmptyBoxCheck(txtPSI))
                {
                    MessageBox.Show("Fields cannot be empty, fill text boxes and try.", "Error- Empty Fields");
                }
                else
                {
                    txtPSI.ReadOnly = true;
                    txtPQ.ReadOnly = true;
                    if (ReceiptNumberCheck(txtPRN))
                    {
                        DialogResult dig = MessageBox.Show("Do you Want to delete the product '" + cmbPPC.Text + "' details from Database ", "Delete Product ", MessageBoxButtons.YesNo);
                        if (dig == DialogResult.Yes)
                        {
                            OleDbConnection con1 = new OleDbConnection(Helper.Connect);
                            OleDbCommand cmd1 = new OleDbCommand("Select * from ProductMasterDT where ProductCode='" + cmbPPC.Text + "'", con1);
                            OleDbCommand cmd2 = new OleDbCommand("Update ProductMasterDT set QuantityOnHand = @UpdatedQuantity where ProductCode='" + cmbPPC.Text + "'", con1);
                            con1.Open();
                            OleDbDataReader dr = cmd1.ExecuteReader();
                            while (dr.Read())
                            {
                                q = (Double)dr["QuantityOnHand"];
                                q1 = int.Parse(txtPQ.Text);
                            }
                            if (q > q1)
                            {
                                qf = q - q1;
                                cmd2.Parameters.AddWithValue("@UpdatedQuantity", qf);
                                OleDbConnection con = new OleDbConnection(Helper.Connect);
                                OleDbCommand cmd = new OleDbCommand("Delete from ProductPurchaseDT where GoodsReceiptNumber=" + txtPRN.Text + "", con);
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
                            PurchasesScreen s5 = new PurchasesScreen();
                            s5.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Receipt Number, please re-check receipt number", "Error");
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
                txtPRN.Text = dataGridViewP.SelectedRows[0].Cells[1].Value.ToString();
                cmbPSC.Text = dataGridViewP.SelectedRows[0].Cells[2].Value.ToString();
                cmbPSN.Text = dataGridViewP.SelectedRows[0].Cells[3].Value.ToString();
                txtPSI.Text = dataGridViewP.SelectedRows[0].Cells[4].Value.ToString();
                cmbPPC.Text = dataGridViewP.SelectedRows[0].Cells[5].Value.ToString();
                cmbPD.Text = dataGridViewP.SelectedRows[0].Cells[6].Value.ToString();
                txtPQ.Text = dataGridViewP.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void cmbPSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Helper.Connect);
                OleDbDataAdapter da = new OleDbDataAdapter("Select SupplierName from SupplierDT where SupplierCode='" + cmbPSC.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmbPSN.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    cmbPSN.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Helper.Connect);
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select ProductDescription from ProductMasterDT where ProductCode='" + cmbPPC.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmbPD.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    cmbPD.Text = "";
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        //Restrictions of textboxes and comboboxes//
        private void txtPSI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtPQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void cmbPSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void cmbPPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void cmbPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void cmbPUOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

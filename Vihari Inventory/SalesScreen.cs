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
    public partial class SalesScreen : Form
    {
        Double q, q1, q2, q3, q4, q5,l,l1;

        private Validate objValidate;
        private Validate NewValidate()
        {
            return new Validate();
        }
        public SalesScreen()
        {
            InitializeComponent();
            objValidate = NewValidate();
        }
        private void SalesScreen_Load(object sender, EventArgs e)
        {
            TimeandSerial();
            ComboFill();
        }
                //Methods for Time,Date and Invoice number//
        private void TimeandSerial()
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbDataAdapter da = new OleDbDataAdapter("Select isnull (max(cast(InvoiceNumber as int)),200000)+1 from ProductSaleDT", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtSIN.Text = dt.Rows[0][0].ToString();

            timer.Start();
            txtSTime.ReadOnly = true;
            txtSDate.ReadOnly = true;
            txtSTime.Text = DateTime.Now.ToLongTimeString();
            txtSDate.Text = DateTime.Now.ToLongDateString();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            txtSTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }
                                         //////Filling Comboboxes/////
        void ComboFill()
        {
            OleDbConnection con = new OleDbConnection(Helper.Connect);
            OleDbCommand cmd = new OleDbCommand("Select * from CustomerDT", con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbSCC.Items.Add(dr["CustomerCode"].ToString());
            }
            dr.Close();
            con.Close();
            OleDbConnection con1 = new OleDbConnection(Helper.Connect);
            OleDbCommand cmd1 = new OleDbCommand("Select * from ProductsSaleCodeDT", con1);
            con1.Open();
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                cmbSPC.Items.Add(dr1["ProductSaleCode"].ToString());
            }
            dr1.Close();
            con1.Close();
        }
                    //Clear method to clear specified textbox values//
        void clear()
        {
            cmbSPC.Text = "";
            txtSPD.Text = "";
            txtSQ.Text = "";
            txtSR.Text = "";
        }
        //Add Button Click//
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (objValidate.EmptyBoxCheck(txtSCN) || objValidate.EmptyBoxCheck(txtSPD) || objValidate.EmptyBoxCheck(txtSR) || objValidate.EmptyBoxCheck(txtSQ)
                   || objValidate.EmptyComboBoxCheck(cmbSCC) || objValidate.EmptyComboBoxCheck(cmbSPC))
                {
                    MessageBox.Show("Fields cannot be empty,enter data to fill textboxes and then try adding.", "Error-Empty Fields");
                }
                else
                {
                    //Deducting Quantity from sales//
                    OleDbConnection con = new OleDbConnection(Helper.Connect);
                    OleDbCommand cmd1 = new OleDbCommand("Select * from ProductMasterDT where ProductCode='" + cmbSPC.Text.Substring(0, 3) + "'", con);
                    OleDbCommand cmd2 = new OleDbCommand("Update ProductMasterDT set QuantityOnHand = @StockUpdate where ProductCode='" + cmbSPC.Text.Substring(0, 3) + "'", con);
                    con.Open();
                    OleDbDataReader dr = cmd1.ExecuteReader();
                    while (dr.Read())
                    {
                        q = (Double)dr["QuantityOnHand"];
                    }
                    //OleDbConnection con1 = new OleDbConnection(Helper.Connect);
                    //OleDbCommand cmd4 = new OleDbCommand("Select * from MaterialMasterDT where MaterialCode='" + cmbSPC.Text + "'", con);
                    //OleDbCommand cmd5 = new OleDbCommand("Update MateriaLMaster set QuantityOnHand = @MUpdate where MaterialCode='" + cmbSPC.Text+ "'", con);
                    //con1.Open();
                    //OleDbDataReader dr1 = cmd4.ExecuteReader();
                    //while(dr1.Read())
                    //{
                    //    l = (Double)dr["QuantityOnHand"];
                    //}
                    //dr1.Close();
                    if (cmbSPC.Text.Length == 7)
                    {
                        for (int i = 0; i < (dataGridViewS.Rows.Count); i++)
                        {
                            if (cmbSPC.Text == dataGridViewS.Rows[i].Cells[0].Value.ToString())
                            {
                                MessageBox.Show("Similar product Already entered, if you want to change the quantity delete the entry and try adding again", "Error-Product Already Entered");
                                clear();
                                return;
                            }
                        }
                        q1 = int.Parse(cmbSPC.Text.Substring(3, 4));
                        q2 = q1 / 1000;
                        q3 = int.Parse(txtSQ.Text);
                        q4 = q2 * q3;
                        if (q4 < q)
                        {
                            q5 = q - q4;
                            ////cmd2.Parameters.AddWithValue("@StockUpdate", q5);
                            dataGridViewS.Rows.Add(cmbSPC.Text, txtSPD.Text, txtSR.Text, txtSQ.Text);
                            for (int n = 0; n < (dataGridViewS.Rows.Count); n++)
                            {
                                double s = Convert.ToDouble(dataGridViewS.Rows[n].Cells[2].Value);
                                int s1 = Convert.ToInt32(dataGridViewS.Rows[n].Cells[3].Value);
                                double s2 = s1 * s;
                                dataGridViewS.Rows[n].Cells[4].Value = s2;
                            }
                        }
                        else
                        {
                            MessageBox.Show("The quantity you are trying to sell is more than the quantity on hand, try decreasing the quatinty.", "Insufficient Stock");
                            cmd2.Parameters.AddWithValue("@StockUpdate", q);
                        }
                        dr.Close();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        clear();
                    }
                    else
                    {
                        for (int i = 0; i < (dataGridViewS.Rows.Count); i++)
                        {
                            if (cmbSPC.Text == dataGridViewS.Rows[i].Cells[0].Value.ToString())
                            {
                                MessageBox.Show("Similar product Already entered, if you want to change the quantity delete the entry and try adding again", "Error-Product Already Entered");
                                clear();
                                return;
                            }
                        }
                        q1 = int.Parse(cmbSPC.Text.Substring(3, 3));
                        q2 = q1 / 1000;
                        q3 = int.Parse(txtSQ.Text);
                        q4 = q2 * q3;
                        //Checking if current stock quantity is more than the selling quantity//
                        if (q4 < q)
                        {
                            q5 = q - q4;
                            //MessageBox.Show(q4.ToString());
                            cmd2.Parameters.AddWithValue("@StockUpdate", q5);

                            //Adding Data to Gridview//
                            dataGridViewS.Rows.Add(cmbSPC.Text, txtSPD.Text, txtSR.Text, txtSQ.Text);
                            for (int n = 0; n < (dataGridViewS.Rows.Count); n++)
                            {
                                double s = Convert.ToDouble(dataGridViewS.Rows[n].Cells[2].Value);
                                int s1 = Convert.ToInt32(dataGridViewS.Rows[n].Cells[3].Value);
                                double s2 = s1 * s;
                                dataGridViewS.Rows[n].Cells[4].Value = s2;
                            }
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("The quantity you are trying to sell is more than the quantity present, try decreasing the  quatinty .", "Insufficient Stock");
                            cmd2.Parameters.AddWithValue("@StockUpdate", q);
                        }
                        dr.Close();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        clear();
                    }
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
                          //Calculating the total amount and grand total amount//
       
                                     //Delete button//
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
            if(objValidate.EmptyBoxCheck(txtSCN)||objValidate.EmptyBoxCheck(txtSPD)|| objValidate.EmptyBoxCheck(txtSR)|| objValidate.EmptyBoxCheck(txtSQ)
                ||objValidate.EmptyComboBoxCheck(cmbSCC) || objValidate.EmptyComboBoxCheck(cmbSPC))
            {
                MessageBox.Show("Fields cannot be empty,please select row from below or fill textboxes to delete data","Error-Empty Fields");
            }
            else
            { 
            DialogResult dig = MessageBox.Show("Do you want to delete any entry from sales process? ", "Delete", MessageBoxButtons.YesNo);

                    if (dig == DialogResult.Yes)
                    {
                        // Update quantity in Product Master i.e. adds the amount quantity of deleted product quantity//
                        OleDbConnection con1 = new OleDbConnection(Helper.Connect);
                        OleDbCommand cmd1 = new OleDbCommand("Select * from ProductMasterDT where ProductCode='" + cmbSPC.Text.Substring(0, 3) + "'", con1);
                        OleDbCommand cmd2 = new OleDbCommand("Update ProductMasterDT set QuantityOnHand = @StockUpdate where ProductCode='" + cmbSPC.Text.Substring(0, 3) + "'", con1);
                        con1.Open();
                        OleDbDataReader dr = cmd1.ExecuteReader();
                        while (dr.Read())
                        {
                            q = (Double)dr["QuantityOnHand"];
                        }
                        if (cmbSPC.Text.Length == 7)
                        {
                            q1 = int.Parse(cmbSPC.Text.Substring(3, 4));
                            q2 = q1 / 1000;
                            q3 = int.Parse(txtSQ.Text);
                            q4 = q2 * q3;
                            q5 = q + q4;
                            //MessageBox.Show(q4.ToString());
                            cmd2.Parameters.AddWithValue("@StockUpdate", q5);
                            dr.Close();
                            cmd2.ExecuteNonQuery();
                            con1.Close();
                            //Deletes selected row from the gridview//
                            if (this.dataGridViewS.SelectedRows.Count > 0)
                            {
                                dataGridViewS.Rows.RemoveAt(this.dataGridViewS.SelectedRows[0].Index);
                            }
                            else
                            {
                                MessageBox.Show("Please select a row to delete");
                            }
                        }
                        else
                        {
                            q1 = int.Parse(cmbSPC.Text.Substring(3, 3));
                            q2 = q1 / 1000;
                            q3 = int.Parse(txtSQ.Text);
                            q4 = q2 * q3;
                            q5 = q + q4;
                            //MessageBox.Show(q4.ToString());
                            cmd2.Parameters.AddWithValue("@StockUpdate", q5);
                            dr.Close();
                            cmd2.ExecuteNonQuery();
                            con1.Close();
                            clear();
                            //Deletes selected row from the gridview//
                            if (this.dataGridViewS.SelectedRows.Count > 0)
                            {
                                dataGridViewS.Rows.RemoveAt(this.dataGridViewS.SelectedRows[0].Index);
                            }
                            else
                            {
                                MessageBox.Show("Please select a row to delete");
                            }
                        }
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridViewS.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridViewS.Rows[i].Cells[4].Value);
                }
                txtTA.Text = sum.ToString();

                //Condition for calculating grand total amount based on discount//
                if (rbnYes.Checked)
                {
                    txtDiscount.ReadOnly = false;
                    txtDiscount.Focus();
                    int price = Convert.ToInt32(txtTA.Text);
                    int percent = Convert.ToInt32(txtDiscount.Text);
                    txtGT.Text = (price - (price * percent) / 100).ToString();
                }
                if (rbnNo.Checked)
                {
                    txtDiscount.Hide();
                    txtGT.Text = (txtTA.Text).ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        //Button Save -  Saves the Data into the database//
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Helper.Connect);
                OleDbCommand cmd1 = new OleDbCommand("Insert into SaleDT values(@SDate, @STime, @InvoiceNumber, @CustomerCode, @CustomerName, @ProductCode, @ProductDescription, @Rate, @SalesQuantity, @SaleValue, @TotalAmount, @Discount, @GrandTotal) ", con);
                con.Open();
                foreach (DataGridViewRow row in dataGridViewS.Rows)
                {
                    cmd1.Parameters.AddWithValue("@SDate", txtSDate.Text);
                    cmd1.Parameters.AddWithValue("@STime", txtSTime.Text);
                    cmd1.Parameters.AddWithValue("@InvoiceNumber", txtSIN.Text);
                    cmd1.Parameters.AddWithValue("@CustomerCode", cmbSCC.Text);
                    cmd1.Parameters.AddWithValue("@CustomerName", txtSCN.Text);
                    cmd1.Parameters.AddWithValue("@ProductCode", row.Cells[0].Value);
                    cmd1.Parameters.AddWithValue("@ProductDescription", row.Cells[1].Value);
                    cmd1.Parameters.AddWithValue("@Rate", row.Cells[2].Value);
                    cmd1.Parameters.AddWithValue("@SaleQuantity", row.Cells[3].Value);
                    cmd1.Parameters.AddWithValue("@SaleValue", row.Cells[4].Value);
                    cmd1.Parameters.AddWithValue("@TotalAmount", txtTA.Text);
                    cmd1.Parameters.AddWithValue("@Discount", txtDiscount.Text);
                    cmd1.Parameters.AddWithValue("@GrandTotal", txtGT.Text);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sale details successfully recorded.", "Saved");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                         //Populating textboxes based on CustomerCode combobox text//
        private void cmbSCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Helper.Connect);
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select CustomerName from CustomerDT where CustomerCode='" + cmbSCC.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtSCN.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    txtSCN.Text = "";
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
                    //Populating textboxes based on ProductCode combobox text//
        private void cmbSPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Helper.Connect);
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select ProductSaleDescription,ProductSaleRate from ProductSaleCodeDT where ProductSaleCode='" + cmbSPC.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtSPD.Text = dt.Rows[0][0].ToString();
                    txtSR.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    txtSPD.Text = "";
                    txtSR.Text = "";
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
                             //Selects entire row of gridview on click//
        private void dataGridViewS_Click(object sender, EventArgs e)
        {
            try
            {
                cmbSPC.Text = dataGridViewS.SelectedRows[0].Cells[0].Value.ToString();
                txtSPD.Text = dataGridViewS.SelectedRows[0].Cells[1].Value.ToString();
                txtSR.Text = dataGridViewS.SelectedRows[0].Cells[2].Value.ToString();
                txtSQ.Text = dataGridViewS.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
                             //Restrictions of textboxes and comboboxes//
        private void txtSCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void rbnYes_Click(object sender, EventArgs e)
        {
            txtDiscount.Show();
        }
        private void rbnNo_Click(object sender, EventArgs e)
        {
            txtDiscount.Hide();
        }
        private void txtSPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtSR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)|| e.KeyChar == '.' || e.KeyChar == (char)Keys.Back);
        }
        private void txtSQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void cmbSCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar)  || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void cmbSPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vihari_Inventory
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            TimeandSerial();
        }
        private void TimeandSerial()
        {  //Time And Date
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

        private void btnProductsMaster_Click(object sender, EventArgs e)
        {
            ProductsMasterScreen s1 = new ProductsMasterScreen();
            s1.Show();
        }

        private void btnProductsSalesCodes_Click(object sender, EventArgs e)
        {
            ProductsSalesCodeScreen s2 = new ProductsSalesCodeScreen();
            s2.Show();
        }

        private void btnSupplierDetails_Click(object sender, EventArgs e)
        {
            SuppliersScreen s3 = new SuppliersScreen();
            s3.Show();
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            CustomerDetailsScreen s4 = new CustomerDetailsScreen();
            s4.Show();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            PurchasesScreen s5 = new PurchasesScreen();
            s5.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesScreen s6 = new SalesScreen();
            s6.Show();
        }
        private void btnMaterialMaster_Click(object sender, EventArgs e)
        {
            MaterialMasterScreen s7 = new MaterialMasterScreen();
            s7.Show();
        }

        private void btnMaterialPurchases_Click(object sender, EventArgs e)
        {
            MaterialPurchasesScreen s8 = new MaterialPurchasesScreen();
            s8.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //ReportsScreen s7 = new ReportsScreen();
            //s7.Show();
        }

        private void linkPM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //PurchaseRegister s7 = new PurchaseRegister();
            //s7.Show();
        }

        private void linkSR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SalesReports s8 = new SalesReports();
            //s8.Show();
        }

        private void linkStR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //StockReport s9 = new StockReport();
            //s9.Show();
        }

        private void linkSL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SuppliersList s10 = new SuppliersList();
            //s10.Show();
        }

        private void linkCL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //CustomersList s11 = new CustomersList();
            //s11.Show();
        }

        private void linkPWR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ProductWiseReports s12 = new ProductWiseReports();
            //s12.Show();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        
    }
}

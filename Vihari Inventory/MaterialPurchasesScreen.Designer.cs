namespace Vihari_Inventory
{
    partial class MaterialPurchasesScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewM = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMD = new System.Windows.Forms.ComboBox();
            this.cmbMSC = new System.Windows.Forms.ComboBox();
            this.cmbMSN = new System.Windows.Forms.ComboBox();
            this.cmbMC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMQ = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMTime = new System.Windows.Forms.TextBox();
            this.txtMDate = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtPRN = new System.Windows.Forms.TextBox();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(259, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 10021;
            this.label11.Text = "Supplier Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 10019;
            this.label6.Text = "Supplier Code:";
            // 
            // dataGridViewM
            // 
            this.dataGridViewM.AllowUserToAddRows = false;
            this.dataGridViewM.AllowUserToDeleteRows = false;
            this.dataGridViewM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column8,
            this.Column11,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewM.Location = new System.Drawing.Point(15, 256);
            this.dataGridViewM.Name = "dataGridViewM";
            this.dataGridViewM.ReadOnly = true;
            this.dataGridViewM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewM.Size = new System.Drawing.Size(709, 347);
            this.dataGridViewM.TabIndex = 10018;
            this.dataGridViewM.Click += new System.EventHandler(this.dataGridViewP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(297, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 41);
            this.label9.TabIndex = 10017;
            this.label9.Text = "Material Purchases";
            // 
            // cmbMD
            // 
            this.cmbMD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbMD.FormattingEnabled = true;
            this.cmbMD.Location = new System.Drawing.Point(372, 166);
            this.cmbMD.Name = "cmbMD";
            this.cmbMD.Size = new System.Drawing.Size(342, 24);
            this.cmbMD.TabIndex = 3;
            this.cmbMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMD_KeyPress);
            // 
            // cmbMSC
            // 
            this.cmbMSC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMSC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.cmbMSC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbMSC.FormattingEnabled = true;
            this.cmbMSC.Location = new System.Drawing.Point(132, 124);
            this.cmbMSC.Name = "cmbMSC";
            this.cmbMSC.Size = new System.Drawing.Size(113, 24);
            this.cmbMSC.TabIndex = 0;
            this.cmbMSC.SelectedIndexChanged += new System.EventHandler(this.cmbMSC_SelectedIndexChanged);
            this.cmbMSC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMSC_KeyPress);
            // 
            // cmbMSN
            // 
            this.cmbMSN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbMSN.FormattingEnabled = true;
            this.cmbMSN.Location = new System.Drawing.Point(372, 121);
            this.cmbMSN.Name = "cmbMSN";
            this.cmbMSN.Size = new System.Drawing.Size(130, 24);
            this.cmbMSN.TabIndex = 1;
            this.cmbMSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMSN_KeyPress);
            // 
            // cmbMC
            // 
            this.cmbMC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbMC.FormattingEnabled = true;
            this.cmbMC.Location = new System.Drawing.Point(132, 166);
            this.cmbMC.Name = "cmbMC";
            this.cmbMC.Size = new System.Drawing.Size(113, 24);
            this.cmbMC.TabIndex = 2;
            this.cmbMC.SelectedIndexChanged += new System.EventHandler(this.cmbMC_SelectedIndexChanged);
            this.cmbMC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMC_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 10016;
            this.label1.Text = "Quantity:";
            // 
            // txtMQ
            // 
            this.txtMQ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMQ.Location = new System.Drawing.Point(132, 205);
            this.txtMQ.MaxLength = 4;
            this.txtMQ.Name = "txtMQ";
            this.txtMQ.Size = new System.Drawing.Size(113, 22);
            this.txtMQ.TabIndex = 10005;
            this.txtMQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMQ_KeyPress);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModify.Location = new System.Drawing.Point(785, 298);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 10007;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Exit.Location = new System.Drawing.Point(785, 377);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 10009;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(785, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10008;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(785, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10006;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 10015;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 10014;
            this.label2.Text = "Material Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(706, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 10013;
            this.label7.Text = "Time :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(709, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 10012;
            this.label8.Text = "Date :";
            // 
            // txtMTime
            // 
            this.txtMTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtMTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMTime.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMTime.Location = new System.Drawing.Point(759, 56);
            this.txtMTime.Name = "txtMTime";
            this.txtMTime.ReadOnly = true;
            this.txtMTime.Size = new System.Drawing.Size(126, 15);
            this.txtMTime.TabIndex = 10011;
            // 
            // txtMDate
            // 
            this.txtMDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtMDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMDate.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMDate.Location = new System.Drawing.Point(759, 20);
            this.txtMDate.Name = "txtMDate";
            this.txtMDate.ReadOnly = true;
            this.txtMDate.Size = new System.Drawing.Size(127, 15);
            this.txtMDate.TabIndex = 10010;
            this.txtMDate.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 10023;
            this.label4.Text = "Receipt Number:";
            // 
            // txtPRN
            // 
            this.txtPRN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPRN.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPRN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPRN.Location = new System.Drawing.Point(132, 10);
            this.txtPRN.Name = "txtPRN";
            this.txtPRN.ReadOnly = true;
            this.txtPRN.Size = new System.Drawing.Size(100, 15);
            this.txtPRN.TabIndex = 10022;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "Date";
            this.Column6.MaxInputLength = 100;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 55;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Receipt Number";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Supplier Code";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Supplier Name";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Material Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Material Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 114;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity Purchased";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // MaterialPurchasesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 615);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPRN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbMD);
            this.Controls.Add(this.cmbMSC);
            this.Controls.Add(this.cmbMSN);
            this.Controls.Add(this.cmbMC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMQ);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMTime);
            this.Controls.Add(this.txtMDate);
            this.Name = "MaterialPurchasesScreen";
            this.Text = "Material Purchases";
            this.Load += new System.EventHandler(this.MaterialPurchasesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMD;
        private System.Windows.Forms.ComboBox cmbMSC;
        private System.Windows.Forms.ComboBox cmbMSN;
        private System.Windows.Forms.ComboBox cmbMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMQ;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMTime;
        private System.Windows.Forms.TextBox txtMDate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
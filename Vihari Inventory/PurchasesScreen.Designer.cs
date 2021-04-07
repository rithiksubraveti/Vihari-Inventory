namespace Vihari_Inventory
{
    partial class PurchasesScreen
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
            this.btnModify = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPTime = new System.Windows.Forms.TextBox();
            this.txtPDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPQ = new System.Windows.Forms.TextBox();
            this.cmbPPC = new System.Windows.Forms.ComboBox();
            this.cmbPSN = new System.Windows.Forms.ComboBox();
            this.cmbPSC = new System.Windows.Forms.ComboBox();
            this.cmbPD = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewP = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtPRN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPSI = new System.Windows.Forms.TextBox();
            this.txtUOM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModify.Location = new System.Drawing.Point(749, 148);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Exit.Location = new System.Drawing.Point(749, 227);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(749, 188);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(749, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(289, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 86;
            this.label5.Text = "UOM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "Product Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(695, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "Time :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(698, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 81;
            this.label8.Text = "Date :";
            // 
            // txtPTime
            // 
            this.txtPTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtPTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPTime.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPTime.Location = new System.Drawing.Point(748, 56);
            this.txtPTime.Name = "txtPTime";
            this.txtPTime.ReadOnly = true;
            this.txtPTime.Size = new System.Drawing.Size(126, 15);
            this.txtPTime.TabIndex = 80;
            // 
            // txtPDate
            // 
            this.txtPDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtPDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPDate.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPDate.Location = new System.Drawing.Point(748, 20);
            this.txtPDate.Name = "txtPDate";
            this.txtPDate.ReadOnly = true;
            this.txtPDate.Size = new System.Drawing.Size(127, 15);
            this.txtPDate.TabIndex = 79;
            this.txtPDate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Quantity:";
            // 
            // txtPQ
            // 
            this.txtPQ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPQ.Location = new System.Drawing.Point(121, 205);
            this.txtPQ.MaxLength = 6;
            this.txtPQ.Name = "txtPQ";
            this.txtPQ.Size = new System.Drawing.Size(113, 22);
            this.txtPQ.TabIndex = 4;
            this.txtPQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPQ_KeyPress);
            // 
            // cmbPPC
            // 
            this.cmbPPC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPPC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPPC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbPPC.FormattingEnabled = true;
            this.cmbPPC.Location = new System.Drawing.Point(121, 166);
            this.cmbPPC.Name = "cmbPPC";
            this.cmbPPC.Size = new System.Drawing.Size(113, 24);
            this.cmbPPC.TabIndex = 2;
            this.cmbPPC.SelectedIndexChanged += new System.EventHandler(this.cmbPPC_SelectedIndexChanged);
            this.cmbPPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPPC_KeyPress);
            // 
            // cmbPSN
            // 
            this.cmbPSN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbPSN.FormattingEnabled = true;
            this.cmbPSN.Location = new System.Drawing.Point(567, 124);
            this.cmbPSN.Name = "cmbPSN";
            this.cmbPSN.Size = new System.Drawing.Size(121, 24);
            this.cmbPSN.TabIndex = 10000;
            this.cmbPSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPUOM_KeyPress);
            // 
            // cmbPSC
            // 
            this.cmbPSC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPSC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.cmbPSC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbPSC.FormattingEnabled = true;
            this.cmbPSC.Location = new System.Drawing.Point(121, 124);
            this.cmbPSC.Name = "cmbPSC";
            this.cmbPSC.Size = new System.Drawing.Size(113, 24);
            this.cmbPSC.TabIndex = 0;
            this.cmbPSC.SelectedIndexChanged += new System.EventHandler(this.cmbPSC_SelectedIndexChanged);
            this.cmbPSC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPSC_KeyPress);
            // 
            // cmbPD
            // 
            this.cmbPD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbPD.FormattingEnabled = true;
            this.cmbPD.Location = new System.Drawing.Point(337, 166);
            this.cmbPD.Name = "cmbPD";
            this.cmbPD.Size = new System.Drawing.Size(342, 24);
            this.cmbPD.TabIndex = 3;
            this.cmbPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPD_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(349, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 41);
            this.label9.TabIndex = 96;
            this.label9.Text = "Purchases";
            // 
            // dataGridViewP
            // 
            this.dataGridViewP.AllowUserToAddRows = false;
            this.dataGridViewP.AllowUserToDeleteRows = false;
            this.dataGridViewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column9,
            this.Column8,
            this.Column11,
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewP.Location = new System.Drawing.Point(12, 256);
            this.dataGridViewP.Name = "dataGridViewP";
            this.dataGridViewP.ReadOnly = true;
            this.dataGridViewP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewP.Size = new System.Drawing.Size(812, 347);
            this.dataGridViewP.TabIndex = 97;
            this.dataGridViewP.Click += new System.EventHandler(this.dataGridViewP_Click);
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
            // Column9
            // 
            this.Column9.HeaderText = "Goods Receipt Number";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
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
            // Column10
            // 
            this.Column10.HeaderText = "Supplier Invoice Number";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Product Description";
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
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtPRN
            // 
            this.txtPRN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPRN.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPRN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPRN.Location = new System.Drawing.Point(132, 20);
            this.txtPRN.Name = "txtPRN";
            this.txtPRN.ReadOnly = true;
            this.txtPRN.Size = new System.Drawing.Size(100, 15);
            this.txtPRN.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "Receipt Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 100;
            this.label6.Text = "Supplier Code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(262, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 101;
            this.label10.Text = "Invoice #:";
            // 
            // txtPSI
            // 
            this.txtPSI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPSI.Location = new System.Drawing.Point(337, 124);
            this.txtPSI.MaxLength = 15;
            this.txtPSI.Name = "txtPSI";
            this.txtPSI.Size = new System.Drawing.Size(100, 22);
            this.txtPSI.TabIndex = 1;
            this.txtPSI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPSI_KeyPress);
            // 
            // txtUOM
            // 
            this.txtUOM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtUOM.Location = new System.Drawing.Point(337, 205);
            this.txtUOM.MaxLength = 5;
            this.txtUOM.Name = "txtUOM";
            this.txtUOM.Size = new System.Drawing.Size(100, 22);
            this.txtUOM.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(458, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 10001;
            this.label11.Text = "Supplier Name:";
            // 
            // PurchasesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(887, 615);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUOM);
            this.Controls.Add(this.txtPSI);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPRN);
            this.Controls.Add(this.dataGridViewP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbPD);
            this.Controls.Add(this.cmbPSC);
            this.Controls.Add(this.cmbPSN);
            this.Controls.Add(this.cmbPPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPQ);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPTime);
            this.Controls.Add(this.txtPDate);
            this.Name = "PurchasesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.PurchasesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPTime;
        private System.Windows.Forms.TextBox txtPDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPQ;
        private System.Windows.Forms.ComboBox cmbPPC;
        private System.Windows.Forms.ComboBox cmbPSN;
        private System.Windows.Forms.ComboBox cmbPSC;
        private System.Windows.Forms.ComboBox cmbPD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewP;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtPRN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPSI;
        private System.Windows.Forms.TextBox txtUOM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
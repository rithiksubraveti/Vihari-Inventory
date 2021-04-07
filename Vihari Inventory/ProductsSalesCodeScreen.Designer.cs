namespace Vihari_Inventory
{
    partial class ProductsSalesCodeScreen
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPSCRate = new System.Windows.Forms.TextBox();
            this.txtPSCDescription = new System.Windows.Forms.TextBox();
            this.txtPSCCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPSCTime = new System.Windows.Forms.TextBox();
            this.txtPSCDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewPSC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPSC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModify.Location = new System.Drawing.Point(792, 304);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(791, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(791, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "Description:";
            // 
            // txtPSCRate
            // 
            this.txtPSCRate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPSCRate.Location = new System.Drawing.Point(272, 211);
            this.txtPSCRate.MaxLength = 4;
            this.txtPSCRate.Name = "txtPSCRate";
            this.txtPSCRate.Size = new System.Drawing.Size(100, 22);
            this.txtPSCRate.TabIndex = 2;
            this.txtPSCRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPSCRate_KeyPress);
            // 
            // txtPSCDescription
            // 
            this.txtPSCDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPSCDescription.Location = new System.Drawing.Point(272, 161);
            this.txtPSCDescription.MaxLength = 300;
            this.txtPSCDescription.Name = "txtPSCDescription";
            this.txtPSCDescription.Size = new System.Drawing.Size(341, 22);
            this.txtPSCDescription.TabIndex = 1;
            this.txtPSCDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPSCDescription_KeyPress);
            // 
            // txtPSCCode
            // 
            this.txtPSCCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPSCCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPSCCode.Location = new System.Drawing.Point(272, 112);
            this.txtPSCCode.MaxLength = 8;
            this.txtPSCCode.Name = "txtPSCCode";
            this.txtPSCCode.Size = new System.Drawing.Size(105, 22);
            this.txtPSCCode.TabIndex = 0;
            this.txtPSCCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPSCCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Product Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(703, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Time :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(703, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 72;
            this.label8.Text = "Date :";
            // 
            // txtPSCTime
            // 
            this.txtPSCTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtPSCTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPSCTime.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPSCTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPSCTime.Location = new System.Drawing.Point(749, 50);
            this.txtPSCTime.Name = "txtPSCTime";
            this.txtPSCTime.ReadOnly = true;
            this.txtPSCTime.Size = new System.Drawing.Size(126, 15);
            this.txtPSCTime.TabIndex = 71;
            // 
            // txtPSCDate
            // 
            this.txtPSCDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtPSCDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPSCDate.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPSCDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPSCDate.Location = new System.Drawing.Point(748, 20);
            this.txtPSCDate.Name = "txtPSCDate";
            this.txtPSCDate.ReadOnly = true;
            this.txtPSCDate.Size = new System.Drawing.Size(127, 15);
            this.txtPSCDate.TabIndex = 70;
            this.txtPSCDate.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(244, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(381, 41);
            this.label9.TabIndex = 69;
            this.label9.Text = "Products Sales Codes";
            // 
            // dataGridViewPSC
            // 
            this.dataGridViewPSC.AllowUserToAddRows = false;
            this.dataGridViewPSC.AllowUserToDeleteRows = false;
            this.dataGridViewPSC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPSC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewPSC.Location = new System.Drawing.Point(97, 264);
            this.dataGridViewPSC.Name = "dataGridViewPSC";
            this.dataGridViewPSC.ReadOnly = true;
            this.dataGridViewPSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPSC.Size = new System.Drawing.Size(583, 325);
            this.dataGridViewPSC.TabIndex = 83;
            this.dataGridViewPSC.Click += new System.EventHandler(this.dataGridViewPSC_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Sales Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Products Sales Rate";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(792, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ProductsSalesCodeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 615);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridViewPSC);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPSCRate);
            this.Controls.Add(this.txtPSCDescription);
            this.Controls.Add(this.txtPSCCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPSCTime);
            this.Controls.Add(this.txtPSCDate);
            this.Controls.Add(this.label9);
            this.Name = "ProductsSalesCodeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Sales Codes ";
            this.Load += new System.EventHandler(this.ProductsSalesCodeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPSCRate;
        private System.Windows.Forms.TextBox txtPSCDescription;
        private System.Windows.Forms.TextBox txtPSCCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPSCTime;
        private System.Windows.Forms.TextBox txtPSCDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewPSC;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
namespace Vihari_Inventory
{
    partial class ProductsMasterScreen
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPMTime = new System.Windows.Forms.TextBox();
            this.txtPMDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPMRate = new System.Windows.Forms.TextBox();
            this.txtPMUOM = new System.Windows.Forms.TextBox();
            this.txtPMQOH = new System.Windows.Forms.TextBox();
            this.txtPMDescription = new System.Windows.Forms.TextBox();
            this.txtPMCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPM)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(700, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Time :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(700, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Date :";
            // 
            // txtPMTime
            // 
            this.txtPMTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtPMTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPMTime.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPMTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPMTime.Location = new System.Drawing.Point(752, 49);
            this.txtPMTime.Name = "txtPMTime";
            this.txtPMTime.ReadOnly = true;
            this.txtPMTime.Size = new System.Drawing.Size(126, 15);
            this.txtPMTime.TabIndex = 54;
            // 
            // txtPMDate
            // 
            this.txtPMDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtPMDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPMDate.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPMDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPMDate.Location = new System.Drawing.Point(751, 19);
            this.txtPMDate.Name = "txtPMDate";
            this.txtPMDate.ReadOnly = true;
            this.txtPMDate.Size = new System.Drawing.Size(127, 15);
            this.txtPMDate.TabIndex = 53;
            this.txtPMDate.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(293, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 41);
            this.label9.TabIndex = 52;
            this.label9.Text = "Products Master";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(800, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(800, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(320, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Unit Of Measurement:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Description:";
            // 
            // txtPMRate
            // 
            this.txtPMRate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPMRate.Location = new System.Drawing.Point(187, 147);
            this.txtPMRate.MaxLength = 10;
            this.txtPMRate.Name = "txtPMRate";
            this.txtPMRate.Size = new System.Drawing.Size(105, 22);
            this.txtPMRate.TabIndex = 2;
            this.txtPMRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPMRate_KeyPress);
            // 
            // txtPMUOM
            // 
            this.txtPMUOM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPMUOM.Location = new System.Drawing.Point(471, 147);
            this.txtPMUOM.MaxLength = 4;
            this.txtPMUOM.Name = "txtPMUOM";
            this.txtPMUOM.Size = new System.Drawing.Size(81, 22);
            this.txtPMUOM.TabIndex = 3;
            this.txtPMUOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPMUOM_KeyPress);
            // 
            // txtPMQOH
            // 
            this.txtPMQOH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPMQOH.Location = new System.Drawing.Point(188, 198);
            this.txtPMQOH.MaxLength = 10;
            this.txtPMQOH.Name = "txtPMQOH";
            this.txtPMQOH.Size = new System.Drawing.Size(105, 22);
            this.txtPMQOH.TabIndex = 4;
            this.txtPMQOH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPMQOH_KeyPress);
            // 
            // txtPMDescription
            // 
            this.txtPMDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPMDescription.Location = new System.Drawing.Point(410, 97);
            this.txtPMDescription.MaxLength = 200;
            this.txtPMDescription.Name = "txtPMDescription";
            this.txtPMDescription.Size = new System.Drawing.Size(258, 22);
            this.txtPMDescription.TabIndex = 1;
            this.txtPMDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPMDescription_KeyPress);
            // 
            // txtPMCode
            // 
            this.txtPMCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPMCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPMCode.Location = new System.Drawing.Point(188, 100);
            this.txtPMCode.MaxLength = 4;
            this.txtPMCode.Name = "txtPMCode";
            this.txtPMCode.Size = new System.Drawing.Size(105, 22);
            this.txtPMCode.TabIndex = 0;
            this.txtPMCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPMCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Product Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(58, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Quantity On Hand:";
            // 
            // dataGridViewPM
            // 
            this.dataGridViewPM.AllowUserToAddRows = false;
            this.dataGridViewPM.AllowUserToDeleteRows = false;
            this.dataGridViewPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dataGridViewPM.Location = new System.Drawing.Point(61, 248);
            this.dataGridViewPM.Name = "dataGridViewPM";
            this.dataGridViewPM.ReadOnly = true;
            this.dataGridViewPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPM.Size = new System.Drawing.Size(623, 332);
            this.dataGridViewPM.TabIndex = 70;
            this.dataGridViewPM.Click += new System.EventHandler(this.dataGridViewPM_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
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
            // Column5
            // 
            this.Column5.HeaderText = "Rate";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unit Of Measurement";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity On Hand";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(800, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModify.Location = new System.Drawing.Point(800, 288);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 71;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // ProductsMasterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 615);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridViewPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPMRate);
            this.Controls.Add(this.txtPMUOM);
            this.Controls.Add(this.txtPMQOH);
            this.Controls.Add(this.txtPMDescription);
            this.Controls.Add(this.txtPMCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPMTime);
            this.Controls.Add(this.txtPMDate);
            this.Controls.Add(this.label9);
            this.Name = "ProductsMasterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Master";
            this.Load += new System.EventHandler(this.ProductsMasterScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPMTime;
        private System.Windows.Forms.TextBox txtPMDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPMRate;
        private System.Windows.Forms.TextBox txtPMUOM;
        private System.Windows.Forms.TextBox txtPMQOH;
        private System.Windows.Forms.TextBox txtPMDescription;
        private System.Windows.Forms.TextBox txtPMCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPM;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnModify;
    }
}
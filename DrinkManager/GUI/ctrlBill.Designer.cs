namespace DrinkManager.GUI
{
    partial class ctrlBill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.txtFindCustomer = new System.Windows.Forms.TextBox();
            this.txtFromPrice = new System.Windows.Forms.TextBox();
            this.txtFindStaff = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.txtToPrice = new System.Windows.Forms.TextBox();
            this.ptbReload = new System.Windows.Forms.PictureBox();
            this.buttonImage11 = new DrinkManager.GUI.ButtonImage1();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReload)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.ColumnHeadersHeight = 30;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnCustomer,
            this.clnPrice,
            this.clnHireDate,
            this.clnPhone,
            this.clnTable});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.EnableHeadersVisualStyles = false;
            this.dgvBill.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBill.Location = new System.Drawing.Point(27, 157);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.Size = new System.Drawing.Size(744, 261);
            this.dgvBill.TabIndex = 5;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // clnID
            // 
            this.clnID.DataPropertyName = "bid";
            this.clnID.HeaderText = "ID";
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            this.clnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnID.Width = 30;
            // 
            // clnCustomer
            // 
            this.clnCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCustomer.DataPropertyName = "customer";
            this.clnCustomer.HeaderText = "Khách hàng";
            this.clnCustomer.Name = "clnCustomer";
            this.clnCustomer.ReadOnly = true;
            // 
            // clnPrice
            // 
            this.clnPrice.DataPropertyName = "price";
            this.clnPrice.HeaderText = "Giá";
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            this.clnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnHireDate
            // 
            this.clnHireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnHireDate.DataPropertyName = "staff";
            this.clnHireDate.HeaderText = "Người Lập Phiếu";
            this.clnHireDate.Name = "clnHireDate";
            this.clnHireDate.ReadOnly = true;
            // 
            // clnPhone
            // 
            this.clnPhone.DataPropertyName = "purchasedate";
            this.clnPhone.HeaderText = "Ngày";
            this.clnPhone.Name = "clnPhone";
            this.clnPhone.ReadOnly = true;
            // 
            // clnTable
            // 
            this.clnTable.DataPropertyName = "tid";
            this.clnTable.HeaderText = "Bàn";
            this.clnTable.Name = "clnTable";
            this.clnTable.ReadOnly = true;
            this.clnTable.Width = 60;
            // 
            // lb
            // 
            this.lb.BackColor = System.Drawing.SystemColors.Control;
            this.lb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(14, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(70, 23);
            this.lb.TabIndex = 6;
            this.lb.Text = "ID";
            this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecting";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Staff";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Table";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTable);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblStaff);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 65);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblTable
            // 
            this.lblTable.BackColor = System.Drawing.SystemColors.Control;
            this.lblTable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(546, 30);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(70, 23);
            this.lblTable.TabIndex = 6;
            this.lblTable.Text = " ";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.Control;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(14, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 23);
            this.lblID.TabIndex = 6;
            this.lblID.Text = " ";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(90, 30);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(121, 23);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = " ";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(212, 30);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 23);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = " ";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(452, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(97, 23);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = " ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStaff
            // 
            this.lblStaff.BackColor = System.Drawing.SystemColors.Control;
            this.lblStaff.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(304, 30);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(150, 23);
            this.lblStaff.TabIndex = 6;
            this.lblStaff.Text = " ";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFindCustomer
            // 
            this.txtFindCustomer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindCustomer.Location = new System.Drawing.Point(5, 17);
            this.txtFindCustomer.Name = "txtFindCustomer";
            this.txtFindCustomer.Size = new System.Drawing.Size(151, 27);
            this.txtFindCustomer.TabIndex = 10;
            this.txtFindCustomer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFromPrice
            // 
            this.txtFromPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromPrice.Location = new System.Drawing.Point(162, 4);
            this.txtFromPrice.Name = "txtFromPrice";
            this.txtFromPrice.Size = new System.Drawing.Size(79, 27);
            this.txtFromPrice.TabIndex = 10;
            this.txtFromPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFindStaff
            // 
            this.txtFindStaff.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindStaff.Location = new System.Drawing.Point(249, 17);
            this.txtFindStaff.Name = "txtFindStaff";
            this.txtFindStaff.Size = new System.Drawing.Size(146, 27);
            this.txtFindStaff.TabIndex = 10;
            this.txtFindStaff.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DrinkManager.Properties.Resources.find;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(720, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlFind
            // 
            this.pnlFind.Controls.Add(this.btnFind);
            this.pnlFind.Controls.Add(this.txtFindCustomer);
            this.pnlFind.Controls.Add(this.txtToPrice);
            this.pnlFind.Controls.Add(this.txtFromPrice);
            this.pnlFind.Controls.Add(this.txtToDate);
            this.pnlFind.Controls.Add(this.txtTable);
            this.pnlFind.Controls.Add(this.txtFromDate);
            this.pnlFind.Controls.Add(this.txtFindStaff);
            this.pnlFind.Location = new System.Drawing.Point(90, 96);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(612, 61);
            this.pnlFind.TabIndex = 14;
            this.pnlFind.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Location = new System.Drawing.Point(564, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(40, 40);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "OK";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromDate.Location = new System.Drawing.Point(401, 4);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(95, 27);
            this.txtFromDate.TabIndex = 10;
            this.txtFromDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDate.Location = new System.Drawing.Point(401, 32);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(95, 27);
            this.txtToDate.TabIndex = 10;
            this.txtToDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTable
            // 
            this.txtTable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTable.Location = new System.Drawing.Point(506, 17);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(38, 27);
            this.txtTable.TabIndex = 10;
            this.txtTable.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtToPrice
            // 
            this.txtToPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToPrice.Location = new System.Drawing.Point(162, 32);
            this.txtToPrice.Name = "txtToPrice";
            this.txtToPrice.Size = new System.Drawing.Size(79, 27);
            this.txtToPrice.TabIndex = 10;
            this.txtToPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ptbReload
            // 
            this.ptbReload.BackgroundImage = global::DrinkManager.Properties.Resources.reload;
            this.ptbReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbReload.Location = new System.Drawing.Point(27, 96);
            this.ptbReload.Name = "ptbReload";
            this.ptbReload.Size = new System.Drawing.Size(62, 61);
            this.ptbReload.TabIndex = 15;
            this.ptbReload.TabStop = false;
            this.ptbReload.Click += new System.EventHandler(this.ptbReload_Click);
            // 
            // buttonImage11
            // 
            this.buttonImage11.BackColor = System.Drawing.Color.Silver;
            this.buttonImage11.ImageIcon = global::DrinkManager.Properties.Resources.print;
            this.buttonImage11.Location = new System.Drawing.Point(691, 12);
            this.buttonImage11.Name = "buttonImage11";
            this.buttonImage11.Size = new System.Drawing.Size(80, 80);
            this.buttonImage11.TabIndex = 8;
            this.buttonImage11.TextButton = "Detail";
            this.buttonImage11.Click += new System.EventHandler(this.buttonImage11_Click);
            // 
            // ctrlBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbReload);
            this.Controls.Add(this.pnlFind);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonImage11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBill);
            this.Name = "ctrlBill";
            this.Size = new System.Drawing.Size(784, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTable;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label2;
        private ButtonImage1 buttonImage11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.TextBox txtFindCustomer;
        private System.Windows.Forms.TextBox txtFromPrice;
        private System.Windows.Forms.TextBox txtFindStaff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToPrice;
        private System.Windows.Forms.PictureBox ptbReload;
    }
}

namespace DrinkManager
{
    partial class ctrlStatistic
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilt = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvFriendlyCustomer = new System.Windows.Forms.DataGridView();
            this.clnCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendlyCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Month";
            // 
            // btnFilt
            // 
            this.btnFilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilt.Location = new System.Drawing.Point(612, 39);
            this.btnFilt.Name = "btnFilt";
            this.btnFilt.Size = new System.Drawing.Size(85, 40);
            this.btnFilt.TabIndex = 4;
            this.btnFilt.Text = "Refilt";
            this.btnFilt.UseVisualStyleBackColor = true;
            this.btnFilt.Click += new System.EventHandler(this.btnFilt_Click);
            // 
            // lblSum
            // 
            this.lblSum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(517, 385);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(115, 25);
            this.lblSum.TabIndex = 5;
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudMonth
            // 
            this.nudMonth.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMonth.Location = new System.Drawing.Point(182, 46);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(74, 33);
            this.nudMonth.TabIndex = 6;
            this.nudMonth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYear.Location = new System.Drawing.Point(334, 46);
            this.nudYear.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(79, 33);
            this.nudYear.TabIndex = 7;
            this.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng thu nhập";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvFriendlyCustomer
            // 
            this.dgvFriendlyCustomer.AllowUserToAddRows = false;
            this.dgvFriendlyCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvFriendlyCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFriendlyCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvFriendlyCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFriendlyCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFriendlyCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFriendlyCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFriendlyCustomer.ColumnHeadersHeight = 30;
            this.dgvFriendlyCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFriendlyCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCID,
            this.clnName,
            this.clnAddress,
            this.clnPhone});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFriendlyCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFriendlyCustomer.EnableHeadersVisualStyles = false;
            this.dgvFriendlyCustomer.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFriendlyCustomer.Location = new System.Drawing.Point(97, 96);
            this.dgvFriendlyCustomer.Name = "dgvFriendlyCustomer";
            this.dgvFriendlyCustomer.ReadOnly = true;
            this.dgvFriendlyCustomer.Size = new System.Drawing.Size(600, 273);
            this.dgvFriendlyCustomer.TabIndex = 8;
            // 
            // clnCID
            // 
            this.clnCID.DataPropertyName = "cid";
            this.clnCID.HeaderText = "Mã Khách Hàng";
            this.clnCID.Name = "clnCID";
            this.clnCID.ReadOnly = true;
            this.clnCID.Width = 120;
            // 
            // clnName
            // 
            this.clnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnName.DataPropertyName = "name";
            this.clnName.HeaderText = "Tên Khách Hàng";
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            // 
            // clnAddress
            // 
            this.clnAddress.DataPropertyName = "time";
            this.clnAddress.HeaderText = "Số Lần Ghé Quán";
            this.clnAddress.Name = "clnAddress";
            this.clnAddress.ReadOnly = true;
            this.clnAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnAddress.Width = 150;
            // 
            // clnPhone
            // 
            this.clnPhone.DataPropertyName = "sumprice";
            this.clnPhone.HeaderText = "Tổng Tiền";
            this.clnPhone.Name = "clnPhone";
            this.clnPhone.ReadOnly = true;
            this.clnPhone.Width = 80;
            // 
            // ctrlStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFriendlyCustomer);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.nudMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnFilt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ctrlStatistic";
            this.Size = new System.Drawing.Size(784, 461);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendlyCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilt;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvFriendlyCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhone;
    }
}

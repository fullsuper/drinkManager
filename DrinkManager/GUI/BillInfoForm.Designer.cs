namespace DrinkManager.GUI
{
    partial class BillInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lsvItemBill = new System.Windows.Forms.ListView();
            this.clnItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = " Detail Bill No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cashier     :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(161, 93);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(158, 23);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Tên Khách hàng";
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashier.Location = new System.Drawing.Point(161, 124);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(187, 23);
            this.lblCashier.TabIndex = 3;
            this.lblCashier.Text = "Tên Người Lập Phiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "List Item";
            // 
            // lsvItemBill
            // 
            this.lsvItemBill.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lsvItemBill.BackColor = System.Drawing.Color.Snow;
            this.lsvItemBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvItemBill.CausesValidation = false;
            this.lsvItemBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnItem,
            this.clnAmount,
            this.clnPrice});
            this.lsvItemBill.Enabled = false;
            this.lsvItemBill.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lsvItemBill.FullRowSelect = true;
            this.lsvItemBill.HotTracking = true;
            this.lsvItemBill.HoverSelection = true;
            this.lsvItemBill.Location = new System.Drawing.Point(51, 268);
            this.lsvItemBill.Name = "lsvItemBill";
            this.lsvItemBill.Size = new System.Drawing.Size(387, 188);
            this.lsvItemBill.TabIndex = 4;
            this.lsvItemBill.UseCompatibleStateImageBehavior = false;
            this.lsvItemBill.View = System.Windows.Forms.View.Details;
            // 
            // clnItem
            // 
            this.clnItem.Text = "Item";
            this.clnItem.Width = 167;
            // 
            // clnAmount
            // 
            this.clnAmount.Text = "Amount";
            this.clnAmount.Width = 89;
            // 
            // clnPrice
            // 
            this.clnPrice.Text = "Price/One";
            this.clnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clnPrice.Width = 129;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Table  :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(218, 173);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 21);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Ngày mua";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(218, 195);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(40, 21);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Bàn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(285, 483);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPrice.Size = new System.Drawing.Size(112, 22);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "Tổng Giá Trị";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrintBill.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrintBill.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnPrintBill.FlatAppearance.BorderSize = 12;
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBill.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrintBill.Location = new System.Drawing.Point(183, 556);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(88, 54);
            this.btnPrintBill.TabIndex = 7;
            this.btnPrintBill.Text = "Print";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "- - - - - - - - - - - - - -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "- - - - - - - - - - - - - -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "- - - - - - - - - - - - - -";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(294, 51);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 32);
            this.lblID.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 516);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 22);
            this.label11.TabIndex = 9;
            this.label11.Text = "See you later! <3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 483);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "VNĐ";
            // 
            // BillInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(469, 617);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lsvItemBill);
            this.Controls.Add(this.lblCashier);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BillInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillInfoForm";
            this.Load += new System.EventHandler(this.BillInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsvItemBill;
        private System.Windows.Forms.ColumnHeader clnItem;
        private System.Windows.Forms.ColumnHeader clnAmount;
        private System.Windows.Forms.ColumnHeader clnPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
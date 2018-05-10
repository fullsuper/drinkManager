namespace DrinkManager.GUI
{
    partial class ctrlPurchase
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
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.cbbTypeDrink = new System.Windows.Forms.ComboBox();
            this.txtCus = new System.Windows.Forms.TextBox();
            this.cbbTable = new System.Windows.Forms.ComboBox();
            this.cbbStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbListItem = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImport = new DrinkManager.GUI.ButtonImage1();
            this.btnPurchase = new DrinkManager.GUI.ButtonImage1();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpItems
            // 
            this.flpItems.AutoScroll = true;
            this.flpItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpItems.Location = new System.Drawing.Point(0, 182);
            this.flpItems.Name = "flpItems";
            this.flpItems.Padding = new System.Windows.Forms.Padding(10);
            this.flpItems.Size = new System.Drawing.Size(782, 277);
            this.flpItems.TabIndex = 0;
            // 
            // cbbTypeDrink
            // 
            this.cbbTypeDrink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbbTypeDrink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbTypeDrink.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeDrink.FormattingEnabled = true;
            this.cbbTypeDrink.Location = new System.Drawing.Point(0, 151);
            this.cbbTypeDrink.Name = "cbbTypeDrink";
            this.cbbTypeDrink.Size = new System.Drawing.Size(782, 31);
            this.cbbTypeDrink.TabIndex = 1;
            this.cbbTypeDrink.Text = " --- Choice Type Drink/Food ---";
            this.cbbTypeDrink.SelectedIndexChanged += new System.EventHandler(this.cbbTypeDrink_SelectedIndexChanged);
            // 
            // txtCus
            // 
            this.txtCus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCus.Location = new System.Drawing.Point(109, 99);
            this.txtCus.Name = "txtCus";
            this.txtCus.Size = new System.Drawing.Size(237, 30);
            this.txtCus.TabIndex = 2;
            // 
            // cbbTable
            // 
            this.cbbTable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Location = new System.Drawing.Point(109, 56);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(237, 31);
            this.cbbTable.TabIndex = 3;
            // 
            // cbbStaff
            // 
            this.cbbStaff.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(109, 12);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(237, 31);
            this.cbbStaff.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Staff";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(385, 99);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(169, 33);
            this.nudAmount.TabIndex = 6;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(385, 54);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(169, 33);
            this.txtItem.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecting ...";
            // 
            // cbbListItem
            // 
            this.cbbListItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListItem.FormattingEnabled = true;
            this.cbbListItem.Location = new System.Drawing.Point(616, 107);
            this.cbbListItem.Name = "cbbListItem";
            this.cbbListItem.Size = new System.Drawing.Size(141, 27);
            this.cbbListItem.TabIndex = 9;
            this.cbbListItem.SelectedValueChanged += new System.EventHandler(this.cbbListItem_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DrinkManager.Properties.Resources.deleteicon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(591, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnImport.ImageIcon = global::DrinkManager.Properties.Resources.money;
            this.btnImport.Location = new System.Drawing.Point(591, 21);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 80);
            this.btnImport.TabIndex = 4;
            this.btnImport.TextButton = "Add";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPurchase.ImageIcon = global::DrinkManager.Properties.Resources.bill;
            this.btnPurchase.Location = new System.Drawing.Point(677, 21);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(80, 80);
            this.btnPurchase.TabIndex = 4;
            this.btnPurchase.TextButton = "Purchase";
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // ctrlPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbListItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.cbbStaff);
            this.Controls.Add(this.cbbTable);
            this.Controls.Add(this.txtCus);
            this.Controls.Add(this.cbbTypeDrink);
            this.Controls.Add(this.flpItems);
            this.Name = "ctrlPurchase";
            this.Size = new System.Drawing.Size(782, 459);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.ComboBox cbbTypeDrink;
        private System.Windows.Forms.TextBox txtCus;
        private System.Windows.Forms.ComboBox cbbTable;
        private ButtonImage1 btnPurchase;
        private System.Windows.Forms.ComboBox cbbStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ButtonImage1 btnImport;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbListItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

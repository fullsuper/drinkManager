namespace DrinkManager.GUI
{
    partial class ctrlConfigure
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbType = new System.Windows.Forms.RadioButton();
            this.rdbSupplier = new System.Windows.Forms.RadioButton();
            this.rdbTable = new System.Windows.Forms.RadioButton();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbType);
            this.groupBox1.Controls.Add(this.rdbSupplier);
            this.groupBox1.Controls.Add(this.rdbTable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // rdbType
            // 
            this.rdbType.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbType.BackgroundImage = global::DrinkManager.Properties.Resources.type;
            this.rdbType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbType.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbType.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbType.Location = new System.Drawing.Point(3, 307);
            this.rdbType.Name = "rdbType";
            this.rdbType.Size = new System.Drawing.Size(87, 148);
            this.rdbType.TabIndex = 2;
            this.rdbType.TabStop = true;
            this.rdbType.Text = "Service";
            this.rdbType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdbType.UseVisualStyleBackColor = false;
            this.rdbType.Click += new System.EventHandler(this.rdbType_Click);
            // 
            // rdbSupplier
            // 
            this.rdbSupplier.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbSupplier.BackgroundImage = global::DrinkManager.Properties.Resources.truck_1_512;
            this.rdbSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbSupplier.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSupplier.Location = new System.Drawing.Point(3, 165);
            this.rdbSupplier.Name = "rdbSupplier";
            this.rdbSupplier.Size = new System.Drawing.Size(87, 142);
            this.rdbSupplier.TabIndex = 1;
            this.rdbSupplier.TabStop = true;
            this.rdbSupplier.Text = "Table";
            this.rdbSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdbSupplier.UseVisualStyleBackColor = false;
            this.rdbSupplier.Click += new System.EventHandler(this.rdbSupplier_Click);
            // 
            // rdbTable
            // 
            this.rdbTable.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbTable.BackgroundImage = global::DrinkManager.Properties.Resources.table;
            this.rdbTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbTable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTable.Location = new System.Drawing.Point(3, 23);
            this.rdbTable.Name = "rdbTable";
            this.rdbTable.Size = new System.Drawing.Size(87, 142);
            this.rdbTable.TabIndex = 0;
            this.rdbTable.TabStop = true;
            this.rdbTable.Text = "Table";
            this.rdbTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdbTable.UseVisualStyleBackColor = false;
            this.rdbTable.Click += new System.EventHandler(this.rdbTable_Click);
            // 
            // pnlConfig
            // 
            this.pnlConfig.Location = new System.Drawing.Point(144, 34);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(600, 400);
            this.pnlConfig.TabIndex = 2;
            // 
            // ctrlConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConfig);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlConfigure";
            this.Size = new System.Drawing.Size(784, 461);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSupplier;
        private System.Windows.Forms.RadioButton rdbType;
        private System.Windows.Forms.Panel pnlConfig;
    }
}

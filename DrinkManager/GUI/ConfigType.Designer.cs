namespace DrinkManager.GUI
{
    partial class ConfigType
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTypeToolStripMenuItem,
            this.serviceTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemTypeToolStripMenuItem
            // 
            this.itemTypeToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.itemTypeToolStripMenuItem.Name = "itemTypeToolStripMenuItem";
            this.itemTypeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.itemTypeToolStripMenuItem.Text = "ItemType";
            this.itemTypeToolStripMenuItem.Click += new System.EventHandler(this.itemTypeToolStripMenuItem_Click);
            // 
            // serviceTypeToolStripMenuItem
            // 
            this.serviceTypeToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.serviceTypeToolStripMenuItem.Name = "serviceTypeToolStripMenuItem";
            this.serviceTypeToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.serviceTypeToolStripMenuItem.Text = "ServiceType";
            this.serviceTypeToolStripMenuItem.Click += new System.EventHandler(this.serviceTypeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 373);
            this.panel1.TabIndex = 1;
            // 
            // ConfigType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ConfigType";
            this.Size = new System.Drawing.Size(600, 400);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceTypeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

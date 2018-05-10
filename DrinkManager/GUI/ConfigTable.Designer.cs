namespace DrinkManager.GUI
{
    partial class ConfigTable
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
            this.flpScreen = new System.Windows.Forms.FlowLayoutPanel();
            this.ptbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // flpScreen
            // 
            this.flpScreen.AutoScroll = true;
            this.flpScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpScreen.Location = new System.Drawing.Point(0, 0);
            this.flpScreen.Name = "flpScreen";
            this.flpScreen.Size = new System.Drawing.Size(600, 342);
            this.flpScreen.TabIndex = 0;
            // 
            // ptbAdd
            // 
            this.ptbAdd.BackgroundImage = global::DrinkManager.Properties.Resources.plusicon_svg;
            this.ptbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbAdd.Location = new System.Drawing.Point(0, 342);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Padding = new System.Windows.Forms.Padding(5);
            this.ptbAdd.Size = new System.Drawing.Size(600, 50);
            this.ptbAdd.TabIndex = 1;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Click += new System.EventHandler(this.ptbAdd_Click);
            // 
            // ConfigTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbAdd);
            this.Controls.Add(this.flpScreen);
            this.Name = "ConfigTable";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpScreen;
        private System.Windows.Forms.PictureBox ptbAdd;
    }
}

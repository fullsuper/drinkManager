namespace DrinkManager.Report
{
    partial class Bill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSQLTS = new DrinkManager.DSQLTS();
            this.dSQLTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new DrinkManager.DSQLTSTableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSQLTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSQLTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DrinkManager.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(368, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dSQLTSBindingSource;
            // 
            // dSQLTS
            // 
            this.dSQLTS.DataSetName = "DSQLTS";
            this.dSQLTS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSQLTSBindingSource
            // 
            this.dSQLTSBindingSource.DataSource = this.dSQLTS;
            this.dSQLTSBindingSource.Position = 0;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 453);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSQLTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSQLTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSQLTS dSQLTS;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private System.Windows.Forms.BindingSource dSQLTSBindingSource;
        private DSQLTSTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
    }
}
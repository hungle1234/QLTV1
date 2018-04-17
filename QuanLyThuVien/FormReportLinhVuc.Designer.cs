namespace QuanLyThuVien
{
    partial class FormReportLinhVuc
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
            this.DataSetLinhVuc = new QuanLyThuVien.DataSetLinhVuc();
            this.tblLinhVucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLinhVucTableAdapter = new QuanLyThuVien.DataSetLinhVucTableAdapters.tblLinhVucTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetLinhVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLinhVucBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblLinhVucBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report10.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(938, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetLinhVuc
            // 
            this.DataSetLinhVuc.DataSetName = "DataSetLinhVuc";
            this.DataSetLinhVuc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLinhVucBindingSource
            // 
            this.tblLinhVucBindingSource.DataMember = "tblLinhVuc";
            this.tblLinhVucBindingSource.DataSource = this.DataSetLinhVuc;
            // 
            // tblLinhVucTableAdapter
            // 
            this.tblLinhVucTableAdapter.ClearBeforeFill = true;
            // 
            // frmrpLinhVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 500);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrpLinhVuc";
            this.Text = "frmrpLinhVuc";
            this.Load += new System.EventHandler(this.frmrpLinhVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetLinhVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLinhVucBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblLinhVucBindingSource;
        private DataSetLinhVuc DataSetLinhVuc;
        private DataSetLinhVucTableAdapters.tblLinhVucTableAdapter tblLinhVucTableAdapter;
    }
}
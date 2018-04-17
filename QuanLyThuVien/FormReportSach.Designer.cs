namespace QuanLyThuVien
{
    partial class FormReportSach
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
            this.DataSetSach = new QuanLyThuVien.DataSetSach();
            this.tblSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSachTableAdapter = new QuanLyThuVien.DataSetSachTableAdapters.tblSachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblSachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(925, 495);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetSach
            // 
            this.DataSetSach.DataSetName = "DataSetSach";
            this.DataSetSach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSachBindingSource
            // 
            this.tblSachBindingSource.DataMember = "tblSach";
            this.tblSachBindingSource.DataSource = this.DataSetSach;
            // 
            // tblSachTableAdapter
            // 
            this.tblSachTableAdapter.ClearBeforeFill = true;
            // 
            // frmrpSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 495);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrpSach";
            this.Text = "frmrpSach";
            this.Load += new System.EventHandler(this.frmrpSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSachBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblSachBindingSource;
        private DataSetSach DataSetSach;
        private DataSetSachTableAdapters.tblSachTableAdapter tblSachTableAdapter;
    }
}
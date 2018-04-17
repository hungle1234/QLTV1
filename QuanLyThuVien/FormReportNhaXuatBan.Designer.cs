namespace QuanLyThuVien
{
    partial class FormReportNhaXuatBan
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
            this.DataSetNhaXuatBan = new QuanLyThuVien.DataSetNhaXuatBan();
            this.tblNXBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNXBTableAdapter = new QuanLyThuVien.DataSetNhaXuatBanTableAdapters.tblNXBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNhaXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNXBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblNXBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report11.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(926, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetNhaXuatBan
            // 
            this.DataSetNhaXuatBan.DataSetName = "DataSetNhaXuatBan";
            this.DataSetNhaXuatBan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNXBBindingSource
            // 
            this.tblNXBBindingSource.DataMember = "tblNXB";
            this.tblNXBBindingSource.DataSource = this.DataSetNhaXuatBan;
            // 
            // tblNXBTableAdapter
            // 
            this.tblNXBTableAdapter.ClearBeforeFill = true;
            // 
            // frmrpNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 489);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrpNXB";
            this.Text = "frmrpNXB";
            this.Load += new System.EventHandler(this.frmrpNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNhaXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNXBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblNXBBindingSource;
        private DataSetNhaXuatBan DataSetNhaXuatBan;
        private DataSetNhaXuatBanTableAdapters.tblNXBTableAdapter tblNXBTableAdapter;
    }
}
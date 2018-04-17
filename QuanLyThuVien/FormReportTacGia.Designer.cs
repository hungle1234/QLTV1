namespace QuanLyThuVien
{
    partial class FormReportTacGia
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetTacGia = new QuanLyThuVien.DataSetTacGia();
            this.tblTacGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTacGiaTableAdapter = new QuanLyThuVien.DataSetTacGiaTableAdapters.tblTacGiaTableAdapter();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTacGiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tblTacGiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(895, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetTacGia
            // 
            this.DataSetTacGia.DataSetName = "DataSetTacGia";
            this.DataSetTacGia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTacGiaBindingSource
            // 
            this.tblTacGiaBindingSource.DataMember = "tblTacGia";
            this.tblTacGiaBindingSource.DataSource = this.DataSetTacGia;
            // 
            // tblTacGiaTableAdapter
            // 
            this.tblTacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(179, 34);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(176, 20);
            this.txtTuKhoa.TabIndex = 1;
            this.txtTuKhoa.Click += new System.EventHandler(this.txtTuKhoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(361, 34);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(508, 39);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 3;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(595, 40);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 4;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.rdbNu_CheckedChanged);
            // 
            // frmrpTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 506);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrpTacGia";
            this.Text = "frmrpTacGia";
            this.Load += new System.EventHandler(this.frmrpTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTacGiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblTacGiaBindingSource;
        private DataSetTacGia DataSetTacGia;
        private DataSetTacGiaTableAdapters.tblTacGiaTableAdapter tblTacGiaTableAdapter;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
    }
}
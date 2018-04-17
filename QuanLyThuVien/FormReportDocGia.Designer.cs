namespace QuanLyThuVien
{
    partial class frmRPDocGia
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
            this.tblDocGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDocGia = new QuanLyThuVien.DataSetDocGia();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblDocGiaTableAdapter = new QuanLyThuVien.DataSetDocGiaTableAdapters.tblDocGiaTableAdapter();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblDocGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDocGiaBindingSource
            // 
            this.tblDocGiaBindingSource.DataMember = "tblDocGia";
            this.tblDocGiaBindingSource.DataSource = this.DataSetDocGia;
            // 
            // DataSetDocGia
            // 
            this.DataSetDocGia.DataSetName = "DataSetDocGia";
            this.DataSetDocGia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblDocGiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(893, 410);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblDocGiaTableAdapter
            // 
            this.tblDocGiaTableAdapter.ClearBeforeFill = true;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(117, 23);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(196, 20);
            this.txtTuKhoa.TabIndex = 1;
            this.txtTuKhoa.Text = "Nhập vào từ khóa cần tìm kiếm";
            this.txtTuKhoa.Click += new System.EventHandler(this.txtTuKhoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(319, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tỉm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(492, 25);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 3;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.Click += new System.EventHandler(this.rdbNam_Click);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(634, 25);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 4;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.rdbNu_CheckedChanged);
            // 
            // frmRPDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 483);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRPDocGia";
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.frmRPDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDocGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblDocGiaBindingSource;
        private DataSetDocGia DataSetDocGia;
        private DataSetDocGiaTableAdapters.tblDocGiaTableAdapter tblDocGiaTableAdapter;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmRPDocGia : Form
    {
        public frmRPDocGia()
        {
            InitializeComponent();
        }
        DataView dv;
        private void frmRPDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetDocGia.tblDocGia' table. You can move, or remove it, as needed.
            this.tblDocGiaTableAdapter.Fill(this.DataSetDocGia.tblDocGia);

            this.reportViewer1.RefreshReport();
            //Tao 1 dataview cua tblDocGia
            dv = new DataView(this.DataSetDocGia.tblDocGia);
            //Gan dataview vao datasource cua tblDocGiaBindingSource
            this.tblDocGiaBindingSource.DataSource = dv;
        }

        private void txtTuKhoa_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Text = "";
            txtTuKhoa.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("HOTEN like '%{0}%'", txtTuKhoa.Text);
            this.reportViewer1.RefreshReport() ;
        }

        private void rdbNam_Click(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("GIOITINH='Nam'");
            this.reportViewer1.RefreshReport();
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("GIOITINH='Nu'");
            this.reportViewer1.RefreshReport();
        }

      
    }
}

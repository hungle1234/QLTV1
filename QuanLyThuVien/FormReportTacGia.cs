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
    public partial class FormReportTacGia : Form
    {
        public FormReportTacGia()
        {
            InitializeComponent();
        }
        DataView dv;
        private void frmrpTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetTacGia.tblTacGia' table. You can move, or remove it, as needed.
            this.tblTacGiaTableAdapter.Fill(this.DataSetTacGia.tblTacGia);
            dv = new DataView(this.DataSetTacGia.tblTacGia);
            this.tblTacGiaBindingSource.DataSource = dv;

            this.reportViewer1.RefreshReport();
        }

        private void txtTuKhoa_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Text = "";
            txtTuKhoa.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("TENTG like '%{0}%'", txtTuKhoa.Text);
            this.reportViewer1.RefreshReport();
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
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

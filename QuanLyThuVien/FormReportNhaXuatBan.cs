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
    public partial class FormReportNhaXuatBan : Form
    {
        public FormReportNhaXuatBan()
        {
            InitializeComponent();
        }

        private void frmrpNXB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetNhaXuatBan.tblNXB' table. You can move, or remove it, as needed.
            this.tblNXBTableAdapter.Fill(this.DataSetNhaXuatBan.tblNXB);

            this.reportViewer1.RefreshReport();
        }
    }
}

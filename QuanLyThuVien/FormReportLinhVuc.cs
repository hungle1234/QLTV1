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
    public partial class FormReportLinhVuc : Form
    {
        public FormReportLinhVuc()
        {
            InitializeComponent();
        }

        private void frmrpLinhVuc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLinhVuc.tblLinhVuc' table. You can move, or remove it, as needed.
            this.tblLinhVucTableAdapter.Fill(this.DataSetLinhVuc.tblLinhVuc);

            this.reportViewer1.RefreshReport();
        }
    }
}

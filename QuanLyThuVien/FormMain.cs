using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormMain : Form
    {
        
       
        public FormMain()
        {
            InitializeComponent();
        }
        public static string TenDN, MatKhau, Quyen;
        SqlCommand sqlCommand;
        public Object layGiaTri(string sql) //lay gia tri cua  cot dau tien trong bang 
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = Con;

            //CHi can lay ve gia tri cua mot truong thoi thi dung pt nao ? - ExecuteScalar
            Object obj = sqlCommand.ExecuteScalar(); //neu co loi thi phai xem lai cua lenh SQL o ben kia
            return obj;
            //Ket qua de dau ? - de trong obj
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TenDN = textBox1.Text;
            MatKhau = textBox2.Text;
            if (TenDN != "")
            {
                object Q = layGiaTri("select QuyenHan from tblNhanVien where TaiKhoan='" + TenDN + "' and MatKhau='" + MatKhau + "'");
                if (Q == null)
                {
                    MessageBox.Show("Sai tài khoản");
                }
                else
                {
                    //MessageBox.Show("Đăng nhập thành công");
                    Quyen = Convert.ToString(Q);
                    if (Quyen == "user")
                    {
                        quảnLyToolStripMenuItem.Enabled = true;
                        tìmKiếmToolStripMenuItem.Enabled = true;
                        tìmKiếmSáchToolStripMenuItem.Enabled = true;
                        tìmKiếmĐGToolStripMenuItem.Enabled = true;
                        cậpNhậtToolStripMenuItem.Enabled = true;
                        mượnSáchToolStripMenuItem.Enabled = true;
                        cậpNhậtSáchToolStripMenuItem.Enabled = true;
                        cậpNhậtTácGiảToolStripMenuItem.Enabled = true;
                        cậpNhậtToolStripMenuItem1.Enabled = true;
                        cậpNhậtLĩnhVựcToolStripMenuItem.Enabled = true;
                        cậpNhậtNhàXuấtBảnToolStripMenuItem.Enabled = true;
                        tácGiảToolStripMenuItem.Enabled = true;
                        nhàXuấtBảnToolStripMenuItem.Enabled = true;
                        lĩnhVựcToolStripMenuItem.Enabled = true;
                        độcGiảToolStripMenuItem.Enabled = true;
                        sáchToolStripMenuItem.Enabled = true;
                        tạoTàiKhoảnToolStripMenuItem.Enabled = false;
                        cậpNhậtNhânViênToolStripMenuItem.Enabled = true;
                        đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    }
                    if (Quyen == "admin")
                    {
                        quảnLyToolStripMenuItem.Enabled = true;
                        tìmKiếmToolStripMenuItem.Enabled = true;
                        tìmKiếmSáchToolStripMenuItem.Enabled = true;
                        KiêmTratoolStripMenuItem1.Enabled = true;
                        tìmKiếmĐGToolStripMenuItem.Enabled = true;
                        cậpNhậtToolStripMenuItem.Enabled = true;
                        mượnSáchToolStripMenuItem.Enabled = true;
                        cậpNhậtSáchToolStripMenuItem.Enabled = true;
                        cậpNhậtTácGiảToolStripMenuItem.Enabled = true;
                        cậpNhậtToolStripMenuItem1.Enabled = true;
                        cậpNhậtLĩnhVựcToolStripMenuItem.Enabled = true;
                        cậpNhậtNhàXuấtBảnToolStripMenuItem.Enabled = true;
                        tácGiảToolStripMenuItem.Enabled = true;
                        nhàXuấtBảnToolStripMenuItem.Enabled = true;
                        lĩnhVựcToolStripMenuItem.Enabled = true;
                        độcGiảToolStripMenuItem.Enabled = true;
                        sáchToolStripMenuItem.Enabled = true;
                        tạoTàiKhoảnToolStripMenuItem.Enabled = true;
                        cậpNhậtNhânViênToolStripMenuItem.Enabled = true;
                        đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    groupBox1.Enabled = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "FormClosing", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        SqlConnection Con;
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                Con = new SqlConnection();
                Con.ConnectionString = @"Data Source=DESKTOP-NVKM6II\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
                Con.Open();
            }
            catch { MessageBox.Show("Không thể kết nối"); }
                
        }

        private void cậpNhậtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCapNhatSach formcapnhatsach = new FormCapNhatSach();
            formcapnhatsach.Show();
        }

        private void cậpNhậtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCapNhatDocGia formcapnhatdocgia = new FormCapNhatDocGia();
            formcapnhatdocgia.Show();
        }
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimKiemSach formtimkiemsach = new FormTimKiemSach();
            formtimkiemsach.Show();
        }

        private void cậpNhậtNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCapNhatNhanVien formcapnhatnhanvien = new FormCapNhatNhanVien();
            formcapnhatnhanvien.Show();
        }

        private void cậpNhậtTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCapNhatTacGia formcapnhattacgia = new FormCapNhatTacGia();
            formcapnhattacgia.Show();
        }

        private void cậpNhậtNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCapNhatNhaXuatBan formcapnhatnhaxuatban = new FormCapNhatNhaXuatBan();
            formcapnhatnhaxuatban.Show();
        }

        private void cậpNhậtLĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinLinhVuc formthongtinlinhvuc = new FormThongTinLinhVuc();
            formthongtinlinhvuc.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau formdoimatkhau = new FormDoiMatKhau();
            formdoimatkhau.Show();
        }
        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoan formtaotaikhoan = new FormTaoTaiKhoan();
            formtaotaikhoan.Show();
        }

        
        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinTacGia formthongtintacgia = new FormThongTinTacGia();
            formthongtintacgia.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinNhaXuatBan formthongtinnhaxuatban = new FormThongTinNhaXuatBan();
            formthongtinnhaxuatban.Show();
        }

        private void lĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinLinhVuc formthongtinlinhvuc = new FormThongTinLinhVuc();
            formthongtinlinhvuc.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinSach formthongtinsach = new FormThongTinSach();
            formthongtinsach.Show();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinDocGia formthongtindocgia = new FormThongTinDocGia();
            formthongtindocgia.Show();
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            quảnLyToolStripMenuItem.Enabled = false;
            tìmKiếmToolStripMenuItem.Enabled = false;
            tìmKiếmSáchToolStripMenuItem.Enabled = false;
            KiêmTratoolStripMenuItem1.Enabled = false;
            tìmKiếmĐGToolStripMenuItem.Enabled = false;
            cậpNhậtToolStripMenuItem.Enabled = false;
            mượnSáchToolStripMenuItem.Enabled = false;
            cậpNhậtSáchToolStripMenuItem.Enabled = false;
            cậpNhậtTácGiảToolStripMenuItem.Enabled = false;
            cậpNhậtToolStripMenuItem1.Enabled = false;
            cậpNhậtLĩnhVựcToolStripMenuItem.Enabled = false;
            cậpNhậtNhàXuấtBảnToolStripMenuItem.Enabled = false;
            tácGiảToolStripMenuItem.Enabled = false;
            nhàXuấtBảnToolStripMenuItem.Enabled = false;
            lĩnhVựcToolStripMenuItem.Enabled = false;
            độcGiảToolStripMenuItem.Enabled = false;
            sáchToolStripMenuItem.Enabled = false;
            tạoTàiKhoảnToolStripMenuItem.Enabled = false;
            cậpNhậtNhânViênToolStripMenuItem.Enabled = false;
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimKiemSach formtimkiemsach = new FormTimKiemSach();
            formtimkiemsach.Show();
        }

        private void tìmKiếmĐGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimkiemDocGia formtimkiemdocgia = new FormTimkiemDocGia();
            formtimkiemdocgia.Show();
        }

        private void KiêmTratoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormKiemTraThongTinNhanVien formkiemtrathongtinnhanvien = new FormKiemTraThongTinNhanVien();
            formkiemtrathongtinnhanvien.Show();
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\User-PC\\Desktop\\help\\help.chm");
        }

        private void báoCáoSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportSach formreportsach = new FormReportSach();
            formreportsach.Show();
        }

        private void báoCáoLĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportLinhVuc formreportlinhvuc = new FormReportLinhVuc();
            formreportlinhvuc.Show();
        }

        private void báoCáoNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportNhaXuatBan formreportnhaxuatban = new FormReportNhaXuatBan();
            formreportnhaxuatban.Show();
        }
        private void báoCáoĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPDocGia formreportdocgia = new frmRPDocGia();
            formreportdocgia.Show();
        }

        private void báoCáoTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportTacGia formreporttacgia = new FormReportTacGia();
            formreporttacgia.Show();
        }

        }
    }

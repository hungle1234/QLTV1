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
                    ////MessageBox.Show("Đăng nhập thành công");
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
            FormCapNhatSach cnsach = new FormCapNhatSach();
            cnsach.Show();
        }

        private void cậpNhậtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCapNhatDocGia cndocgia = new FormCapNhatDocGia();
            cndocgia.Show();
        }
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimKiemSach tk = new FormTimKiemSach();
            tk.Show();
        }

        private void cậpNhậtNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCapNhatNhanVien cnnhanvien = new FormCapNhatNhanVien();
            cnnhanvien.Show();
        }

        private void cậpNhậtTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCapNhatTacGia cnTG = new FormCapNhatTacGia();
            cnTG.Show();
        }

        private void cậpNhậtNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCapNhatNhaXuatBan cnNXB = new FormCapNhatNhaXuatBan();
            cnNXB.Show();
        }

        private void cậpNhậtLĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcapnhatLv cnLV = new frmcapnhatLv();
            cnLV.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau doimatkhau = new FormDoiMatKhau();
            doimatkhau.Show();
        }
        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoan TAO = new FormTaoTaiKhoan();
            TAO.Show();
        }

        
        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinTacGia ttTG = new FormThongTinTacGia();
            ttTG.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinNhaXuatBan ttnxb = new FormThongTinNhaXuatBan();
            ttnxb.Show();
        }

        private void lĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinLinhVuc ttlv = new FormThongTinLinhVuc();
            ttlv.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinSach ttsach = new FormThongTinSach();
            ttsach.Show();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinDocGia ttDG = new FormThongTinDocGia();
            ttDG.Show();
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
            FormTimKiemSach Sach = new FormTimKiemSach();
            Sach.Show();
        }

        private void tìmKiếmĐGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimkiemDocGia Dg = new FormTimkiemDocGia();
            Dg.Show();
        }

        private void KiêmTratoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormKiemTraThongTinNhanVien K = new FormKiemTraThongTinNhanVien();
            K.Show();
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\User-PC\\Desktop\\help\\help.chm");
        }

        private void báoCáoSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportSach rps = new FormReportSach();
            rps.Show();
        }

        private void báoCáoLĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportLinhVuc rplv = new FormReportLinhVuc();
            rplv.Show();
        }

        private void báoCáoNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportNhaXuatBan rpnxb = new FormReportNhaXuatBan();
            rpnxb.Show();
        }
        private void báoCáoĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPDocGia rpdg = new frmRPDocGia();
            rpdg.Show();
        }

        private void báoCáoTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportTacGia rptg = new FormReportTacGia();
            rptg.Show();
        }

        }
    }

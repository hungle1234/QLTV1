using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class FormTimkiemDocGia : Form
    {
        public FormTimkiemDocGia()
        {
            InitializeComponent();
        }
        Class.clsDatabase Cls = new QuanLyThuVien.Class.clsDatabase();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text + ":";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cls.LoadData2DataGridView(dataGridView1, "select*from tblDocGia where " + comboBox1.Text + " like'%" + textBox1.Text + "%'");
        }

       
        private void TimkiemDG_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TimkiemDG_Load(object sender, EventArgs e)
        {
            //Cls.KetNoi();
        }
    }
}

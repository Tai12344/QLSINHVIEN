using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLSINHVIEN.GUI
{
    public partial class SinhVienFrm : Form
    {
        public SinhVienFrm()
        {
            InitializeComponent();
        }

        private void SinhVienFrm_Load(object sender, EventArgs e)
        {
            //if(HeThong.LOAITAIKHOAN != "ADMIN")
            //    btnQuanLi.Visible = false;
            //else btnQuanLi.Visible = true;
        }
        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void ThôngTin_Click(object sender, EventArgs e)
        {
            QuanLiThongTinFrm frm = new QuanLiThongTinFrm();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void chứcNăngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           QuanLiKhoaFrm f = new QuanLiKhoaFrm();
           this.Hide();
           f.ShowDialog();
           this.Show();

        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLopFrm quanLyLopFrm = new QuanLyLopFrm();
            this.Hide();
            quanLyLopFrm.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLiTaiKhoanFrm qu = new QuanLiTaiKhoanFrm();
            this.Hide();
            qu.ShowDialog();
            this.Show();
        }

        private void lớpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanLyLopFrm f = new QuanLyLopFrm();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void mônHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MonHocFrm monHocFrm = new MonHocFrm();
            this.Hide();
            monHocFrm.ShowDialog();
            this.Show();
        }

        private void ĐổiMatKhau_Click_1(object sender, EventArgs e)
        {
            QuanLiMatKhauFrm matKhauFrm = new QuanLiMatKhauFrm();
            this.Hide();
            matKhauFrm.ShowDialog();
            this.Show();
        }

        private void ĐăngXuấtToolsStripMenu_Click(object sender, EventArgs e)
        {

            this.Close();
        }
       
    }
}

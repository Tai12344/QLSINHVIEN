using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSINHVIEN.BLL;

namespace QLSINHVIEN.GUI
{
    public partial class QuanLiKhoaFrm : Form
    {
        public QuanLiKhoaFrm()
        {
            InitializeComponent();
        }

        private void QuanLiKhoaFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Khoa.Instance.DanhSach();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makhoa = txbMaKhoa.Text;
            string tenkhoa = txbTenKhoa.Text;   

            if(makhoa.Length == 0 && tenkhoa.Length == 0)
            {
                MessageBox.Show("Vui long nhap du thong tin" , "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if(BLL_Khoa.Instance.Them(makhoa, tenkhoa) == true)
                    {
                        btnTaiLai.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Ma khoa da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaKhoa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenKhoa.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {   int id = int.Parse(txbID.Text);
            string makhoa = txbMaKhoa.Text;
            string tenkhoa = txbTenKhoa.Text;

            if (makhoa.Length == 0 && tenkhoa.Length == 0)
            {
                MessageBox.Show("Vui long nhap du thong tin", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_Khoa.Instance.Sua(makhoa, tenkhoa, id) == true)
                    {
                        btnTaiLai.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Ma khoa da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string tenkhoa = txbTenKhoa.Text;
            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_Khoa.Instance.Xoa(id) == true)
                {
                    btnTaiLai.PerformClick();
                }
            }
        }
    }
}

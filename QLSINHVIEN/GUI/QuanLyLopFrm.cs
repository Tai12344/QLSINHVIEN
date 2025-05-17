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
    public partial class QuanLyLopFrm : Form
    {
        public QuanLyLopFrm()
        {
            InitializeComponent();
        }

        private void QuanLyLopFrm_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            string makhoa = cbbMaKhoa.SelectedValue.ToString().Trim();
            int soluong = (int)numSoLuong.Value;

            if (malop.Length == 0 && tenlop.Length > 0)
            {
                try 
                {
                    if (BLL_Class.Instance.Them(malop, tenlop, soluong, makhoa) == true)
                    btnTaiLai.PerformClick();
                }
                catch 
                {
                   MessageBox.Show("Mã lớp bị trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống." , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvQuanLiLop.DataSource = BLL_Class.Instance.DanhSach();
            cbbMaKhoa.DataSource = BLL_Class.Instance.DanhSach();
            cbbMaKhoa.DisplayMember = "TenKhoa";
            cbbMaKhoa.ValueMember = "MaKhoa";
            cbbMaKhoa.SelectedIndex = 0;

            if (BLL_Khoa.Instance.DanhSach().Rows.Count > 0)
            {
                cbbMaKhoa.SelectedIndex = 0;
            }
        }
    }
}

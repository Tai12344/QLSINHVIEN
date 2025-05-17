using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSINHVIEN.BLL;

namespace QLSINHVIEN.GUI
{
    public partial class QuanLiTaiKhoanFrm : Form
    {
        public QuanLiTaiKhoanFrm()
        {
            InitializeComponent();
        }

        private void QuanLiTaiKhoanFrm_Load(object sender, EventArgs e)
        {

            if (cbbLoaiTaiKhoan.Items.Count > 0)
                cbbLoaiTaiKhoan.SelectedIndex = 0;

            btnTaiLai.PerformClick();
        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txbTenDangNhap.Text.Trim();
            string matKhau = txbMatKhau.Text.Trim();
            string LoaiTK = cbbLoaiTaiKhoan.SelectedItem.ToString();

            if ( matKhau.Length > 6 && LoaiTK.Length > 0)
            {
                try
                {
                    if (BLL_Account.Instance.Them(tenDangNhap, matKhau, LoaiTK) == true)
                    {
                        MessageBox.Show("Tạo TK Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnTaiLai.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("CCC", "THông báo", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu quá ngắn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txbID.Text, out id))
            {
                MessageBox.Show("ID không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tenDangNhap = txbTenDangNhap.Text.Trim();
            string matKhau = txbMatKhau.Text.Trim();
            string LoaiTK = cbbLoaiTaiKhoan.SelectedItem.ToString();

            if (tenDangNhap.Length > 6 && matKhau.Length > 6 && LoaiTK.Length > 0)
            {

                try
                {   if (matKhau.Length == 0)
                    {   
                    //Khong sua mat khau
                        if (BLL_Account.Instance.KhongSuaMatKhau(tenDangNhap,LoaiTK, id) == true)
                            btnTaiLai.PerformClick();
                    }
                    //Sua mat khau
                    else
                    {
                        if(BLL_Account.Instance.Sua(tenDangNhap, matKhau, LoaiTK, id) == true)
                            btnTaiLai.PerformClick();
                    }
                }

                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu quá ngắn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)

        {   
            int id = int.Parse(dgvQuanLiTaiKhoan.CurrentRow.Cells[0].Value.ToString());
            string ten = dgvQuanLiTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            
            if(MessageBox.Show($"Xóa tài khoản {ten} ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            try 
            {
                if(BLL_Account.Instance.Xoa(id) == true)
                        btnTaiLai.PerformClick();
            }
                catch
                {
                    MessageBox.Show("Lỗi khi xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvQuanLiTaiKhoan.DataSource = BLL_Account.Instance.DanhSach();

        }

        private void dgvQuanLiTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvQuanLiTaiKhoan.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenDangNhap.Text = dgvQuanLiTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            txbMatKhau.Text = dgvQuanLiTaiKhoan.CurrentRow.Cells[2].Value.ToString().Trim();
            cbbLoaiTaiKhoan.SelectedItem = dgvQuanLiTaiKhoan.CurrentRow.Cells[3].Value.ToString().Trim();
        }
    }
}

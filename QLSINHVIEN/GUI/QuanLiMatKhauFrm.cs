using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSINHVIEN.BLL;

namespace QLSINHVIEN.GUI
{
    public partial class QuanLiMatKhauFrm : Form
    {
        public QuanLiMatKhauFrm()
        {
            InitializeComponent();
        }

        private void QuanLiMatKhauFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {   
            string matkhau_cu = txbMatKhauCu.Text;
            string matkhau_moi = txbMatKhauMoi.Text;

            if (matkhau_cu.Length == 0 && matkhau_moi.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BLL_Account.Instance.DoiMatKhau(HeThong.TENDANGNHAP, matkhau_moi, matkhau_cu) == true)
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Đổi mật khẩu thất bại. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}

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
    public partial class QuanLiThongTinFrm : Form
    {
        public QuanLiThongTinFrm()
        {
            InitializeComponent();
        }

        private void QuanLiThongTinFrm_Load(object sender, EventArgs e)
        {
            txbTenDangNhap.Text = HeThong.TENDANGNHAP;
            txbLoaiTaiKhoan.Text = HeThong.LOAITAIKHOAN;

        }
    }
}

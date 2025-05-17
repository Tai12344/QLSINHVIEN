using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace QLSINHVIEN.DAL
{
    public class DAL_Account
    {
        private static DAL_Account instance;
        public static DAL_Account Instance
        {
            get { if (instance == null) instance = new DAL_Account(); return instance; }
            private set => instance = value;
        }
        private DAL_Account() { }

        public bool Them(string ten, string matkhau, string loai)
        {
            string sql = "insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTaiKhoan ) values (@TenDangNhap, @MatKhau, @LoaiTaiKhoan)";
            return DAL_ConnectData.Instance.ExcuteNonQuery(sql, new object[] { ten, matkhau, loai });
        }
        public bool Sua(string makhoa, string tenkhoa, string loai, int id)
        {
            string sql = "update Khoa set MaKhoa = @MaKhoa, TenKhoa = @TenKhoa where id = @id";
            return DAL_ConnectData.Instance.ExcuteNonQuery(sql, new object[] { makhoa, tenkhoa, id });
        }
        public bool Xoa(int id)
        {
            string sql = "delete from  Khoa where id = @id";
            return DAL_ConnectData.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return DAL_ConnectData.Instance.ExcuteQuery("SELECT * FROM TaiKhoan");
        }

        internal bool DoiMatKhau(string tendangnhap, string matkhaumoi, string matkhaucu)
        {
            throw new NotImplementedException();
        }

        internal DataTable DangNhap(string ten, string matkhau)
        {
            throw new NotImplementedException();
        }
    }
}

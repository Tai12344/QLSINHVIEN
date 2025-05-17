using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSINHVIEN.DAL;
using QLSINHVIEN.Session;

namespace QLSINHVIEN.BLL
{
    public class BLL_Account
    {
        private static BLL_Account instance;
        public static BLL_Account Instance
        {
            get { if (instance == null) instance = new BLL_Account(); return instance; }
            private set => instance = value;
        }
        private BLL_Account() { }

        public DataTable DanhSach()
        {
            return DAL_Account.Instance.DanhSach();
        }


        public bool Them(string ten, string matkhau, string loai)
        {
            DataTable danhSach = DAL_Account.Instance.DanhSach();
            foreach (DataRow row in danhSach.Rows)
            {
                if (row["TenDangNhap"].ToString().Trim() == ten.Trim())
                {
                    return false; 
                }
            }
            matkhau = HeThong.Hash(matkhau);
            return DAL_Account.Instance.Them(ten, matkhau, loai);
        }


         
        public bool Sua(string ten, string matkhau, string loai, int id)
        {
            
            return DAL_Account.Instance.Sua(ten, matkhau, loai, id);
        }
        public bool KhongSuaMatKhau(string ten,string loai, int id)
        {
 
            return DAL_ConnectData.Instance.KhongSuaMatKhau(ten, loai, id);
        }
        public bool Xoa(int id)
        {
            
            return DAL_ConnectData.Instance.Xoa(id);
        }
        public bool DangNhap(string ten, string matkhau )
        {
            matkhau = HeThong.Hash(matkhau);

            DataTable Dulieu = DAL_Account.Instance.DangNhap(ten, matkhau);
            MessageBox.Show("so dong tra ve" + Dulieu.Rows.Count);
            if (Dulieu.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                Session.Session.UserName = ten;
                HeThong.TENDANGNHAP = ten;
                HeThong.LOAITAIKHOAN = Dulieu.Rows[0]["LoaiTaiKhoan"].ToString().Trim();
            }
             return true;
        }

        public bool DoiMatKhau(string tendangnhap, string matkhaumoi, string matkhaucu)
        {
            matkhaucu = HeThong.Hash(matkhaucu);
            matkhaumoi = HeThong.Hash(matkhaumoi);
            return DAL_Account.Instance.DoiMatKhau(tendangnhap, matkhaumoi, matkhaucu);
        }
    }
}

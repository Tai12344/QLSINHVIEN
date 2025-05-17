using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSINHVIEN.BLL;

namespace QLSINHVIEN.DAL
{
    public class DAL_Khoa
    {   
        private static DAL_Khoa instance;
        public static DAL_Khoa Instance
        {
            get {if (instance == null) instance = new DAL_Khoa();return instance;}
            private set =>instance = value;
        }
        private DAL_Khoa()
        {
        
        }
        public bool Them(string makhoa, string tenkhoa)
        {   
            string sql = "insert into Khoa(MaKhoa, TenKhoa) values (@MaKhoa, @TenKhoa)";
            return DAL_ConnectData.Instance.ExcuteNonQuery(sql, new object[] { makhoa, tenkhoa});
        }
        public bool Sua(string ten, string matkhau, string loai, int id)
        {
            string sql = "";
            return DAL_ConnectData.Instance.ExcuteNonQuery(sql, new object[] { ten, matkhau, loai, id });
        }
        public bool Xoa(int id)
        {
            string sql = "delete from Khoa where id = @id";
            return DAL_ConnectData.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return DAL_ConnectData.Instance.ExcuteQuery("SELECT * FROM Khoa");
        }

        internal bool Sua(string tenkhoa, string makhoa, int id, string makhoa1, int id1)
        {
            throw new NotImplementedException();
        }

        internal bool Sua(string tenkhoa, string makhoa, int id)
        {
            throw new NotImplementedException();
        }

        public static implicit operator DAL_Khoa(BLL_Khoa v)
        {
            throw new NotImplementedException();
        }
    }
}

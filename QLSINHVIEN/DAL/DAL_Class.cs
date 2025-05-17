using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.DAL
{
    public class DAL_Class
    {
        private static DAL_Class instance;
        public static DAL_Class Instance
        {
            get {if (instance == null) instance = new DAL_Class(); return instance; }
            private set => instance = value;
        }
        private DAL_Class()
        { }
        
        public bool Them(string malop, string tenlop, int soluong , string makhoa)
        {
            string sql = "insert into Lop(MaLop, TenLop, SoLuong, MaKhoa) values (@MaLop, @TenLop, @SoLuong, @MaKhoa)";
            return DAL_ConnectData.Instance.ExcuteNonQuery(sql, new object[] { makhoa, tenlop, malop, soluong });
        }
        public bool Sua(string malop, string tenlop, int soluong, int id)
        {
            string sql = "";
            return DAL_ConnectData.Instance.ExcuteNonQuery(sql, new object[] { tenlop,malop, soluong, id });
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.DAL
{
    public class DAL_MonHoc
    {
        private static DAL_MonHoc instance;
        public static DAL_MonHoc Instance
        {
            get { if (instance == null) instance = new DAL_MonHoc(); return instance; }
            private set => instance = value;
        }
        //private DAL_MocHoc() {}
        public bool Them(string makhoa, string tenkhoa)
        {
            string sql = "insert into Khoa(MaMH,TenMH,TenKhoa, soTC) values (@MaMH,@TenMH, @TenKhoa, @SoTC)";
            return DAL_ConnectData.Instance.ExcuteNonQuery(sql, new object[] {   });
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

    }
}

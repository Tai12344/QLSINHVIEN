using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSINHVIEN.DAL;

namespace QLSINHVIEN.BLL
{
    public class BLL_Class
    {
        private static BLL_Class instance;
        public static BLL_Class Instance
        {
            get { if (instance == null) instance = new BLL_Class(); return instance; }
            private set { instance = value; }
        }
        private BLL_Class() { }

        public DataTable DanhSach()
        {
            return DAL_Class.Instance.DanhSach();
        }

        public bool Them(string malop, string tenlop, int soluong, string makhoa)
        {
            return DAL_Class.Instance.Them(malop, tenlop, soluong, makhoa);
        }

        public bool Sua(string malop, string tenlop, int soluong, string makhoa, int id)
        {

            return DAL_Khoa.Instance.Sua(malop, tenlop, soluong,makhoa, id);
        }
        public bool Xoa(int id)
        {
            return DAL_Khoa.Instance.Xoa(id);
        }
    }
}


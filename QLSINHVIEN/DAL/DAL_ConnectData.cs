using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.DAL
{
    public class DAL_ConnectData
    {   

        private string connectionString = ("Data Source=TYPER09;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True");

        private static DAL_ConnectData instance;

        public static DAL_ConnectData Instance

        {
            get { if (instance == null) instance = new DAL_ConnectData(); return instance; }
            private set => instance = value;
        }
        private DAL_ConnectData() { }

        //lay danh sach

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                if (parameter != null)
                {
                    // Tìm tất cả các @parameters trong câu query
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParams)
                    {
                        if (item.Contains("@"))
                        {
                            string paramName = item.Trim(',', ')', ';'); // loại bỏ ký tự đặc biệt
                            cmd.Parameters.AddWithValue(paramName, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }


        //them, sua, xoa
        public bool ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParams)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]); i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                con.Close();
            }
            return data > 0;
        }

        internal bool KhongSuaMatKhau(string ten, string loai, int id)
        {
            throw new NotImplementedException();
        }

        internal bool Xoa(int id)
        {
            throw new NotImplementedException();
        }
    }
}

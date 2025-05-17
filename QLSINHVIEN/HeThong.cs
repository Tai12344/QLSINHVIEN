using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN
{
        public class HeThong
        {   public static string TENDANGNHAP = " ";
            public static string LOAITAIKHOAN = " ";
            public static string Hash(string text)
            {
                SHA1Managed sha1 = new SHA1Managed();
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
                StringBuilder hashSB = new StringBuilder();
                foreach (byte b in hash)
                {
                    hashSB.Append(b.ToString("X2"));


                }
                return hashSB.ToString();
            }

        internal class Windows
        {
        }
    }

}

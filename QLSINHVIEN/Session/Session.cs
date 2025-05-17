using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.Session
{
    internal class Session
    {
        public static int UserId;
        public static string UserName;
        public static string UserRole;
        public static void clearSession()
        {
            UserId = 0;
            UserName = null;
            UserRole = null;
        }
    }
}

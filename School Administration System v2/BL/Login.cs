using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Administration_System_v2.BL
{
    static class Login
    {
        private static string id;
        private static string password;

        public static void setIDPass(string id, string password)
        {
            Login.id = id;
            Login.password = password;
        }

        public static string getID()
        {
            return id;
        }
        public static string getPasword()
        {
            return password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELVETAS.Data
{
    class UserData
    {
        public static MainForm mainForm { get; set; }

        public static string id_user { get; set; }
        public static string name_user { get; set; }
        public static string type_user { get; set; }

        public static string getInfo()
        {
            return "Ном: " + name_user + "\nНамуди истифодабаранда: " + type_user;
        }

        public static void setInfo(string name, string type)
        {
            name_user = name;
            type_user = type;
        }
    }
}

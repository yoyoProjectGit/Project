using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Form
{
    public class currentUser
    {
        private static string userName = "";
        private static string department = "";
        private static string userId = "";
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public static string Department
        {
            get { return department; }
            set { department = value; }
        }
        public static string UserID
        {
            get { return userId; }
            set { userId = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Form
{
    public class currentStudent
    {
        private string shuId;
        private string firstname;
        private string surname;
        private string coursedept;
        private string emailAddress;
        private string finishDate;

        public string ShuId
        {
            get { return shuId; }
            set { shuId = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string CourseDept
        {
            get { return coursedept; }
            set { coursedept = value; }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        public string FinishDate
        {
            get { return finishDate; }
            set { finishDate = value; }
        }

    }
}

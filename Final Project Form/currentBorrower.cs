using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Form
{
    public class currentBorrower //current borrower class
    {
        private string shuId;
        private string firstname;
        private string surname;
        private string coursedept;
        private string emailAddress;
        private string startDate;
        private string dateCreated;
		private string scannableNum;
		private string userType;

		public string ScannableNum
		{
			get { return scannableNum; }
			set { scannableNum = value; }
		}
		public string UserType
		{
			get { return userType; }
			set { userType = value; }
		}
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
        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public string DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
    }
}

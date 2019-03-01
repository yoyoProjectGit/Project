using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Form
{
    public partial class LoanDurations : Form
    {
        public LoanDurations(string type, string name, int loanprd, string dept,
            long serialNo, string dateAdd, string orderNo, decimal price, string notes, int ID)
        {
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Form
{
    public class OptionsDialog : Form
    {
        private static OptionsDialog openForm = null;

        public static OptionsDialog GetInstance()
        {
            if (openForm == null)
            {
                openForm = new OptionsDialog();
                openForm.FormClosed += delegate { openForm = null; };
            }
            return openForm;
        }
    }
}

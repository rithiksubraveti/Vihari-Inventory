using System;
using System.Collections.Generic;
using System.Drawing;
////using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vihari_Inventory
{
    class Validate
    {
        public bool EmptyBoxCheck(TextBox textbox)
        {
            if(string.IsNullOrEmpty(textbox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EmptyComboBoxCheck(ComboBox combobox)
        {
            if (string.IsNullOrEmpty(combobox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace NesneProje
{
    public class textboxAyarlar
    {

        public textboxAyarlar()
        {

        }
        public void TemizleTumControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control.HasChildren)
                {
                    
                    TemizleTumControls(control.Controls);
                }
            }
        }


    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayFinder
{
    public partial class DayFinder : Form
    {
        private DateTime m;
        
        
        
        public DayFinder()
        {
            InitializeComponent();
        }

        private void btnFindDay_Click(object sender, EventArgs e)
        {
            string[] z = txtDate.Text.Split('-');
            m = new DateTime(int.Parse(z[0]), int.Parse(z[1]), int.Parse(z[2]));
            int l = (int)m.DayOfWeek;
            switch (l)
            {
                case 1: printDay.Text="The day of the given date is Monday";
                    break;
                case 2:
                    printDay.Text = "The day of the given date is Tuesday";
                    break;
                case 3:
                    printDay.Text = "The day of the given date is Wednesday";
                    break;
                case 4:
                    printDay.Text = "The day of the given date is Thursday";
                    break;
                case 5:
                    printDay.Text = "The day of the given date is Friday";
                    break;
                case 6:
                    printDay.Text = "The day of the given date is Saturday";
                    break;
                case 0:
                    printDay.Text = "The day of the given date is Sunday";
                    break;
                default:
                    printDay.Text = "Outside the work";
                    break;
            }

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}

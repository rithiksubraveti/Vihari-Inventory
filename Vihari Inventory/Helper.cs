using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vihari_Inventory
{
    class Helper
    {
        public static string Connect
            {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["Vihari_Inventory.Properties.Settings.VihariDatabaseConnectionString"].ConnectionString;
            }
                

            }

    }
}

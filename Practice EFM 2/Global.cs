using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Practice_EFM_2
{
    class Global
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["Practice_EFM_2.Properties.Settings.hopitalConnectionString"].ConnectionString;
    }
}

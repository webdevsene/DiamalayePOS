using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DiamalayPOS.General
{
    public class ApplicationSettings
    {
        /**
         * on joute une methode static pour la configuration conection
         */
         public static string connectionString()
        {
            return ConfigurationManager.ConnectionStrings["rbx"].ConnectionString;
        }
    }
}

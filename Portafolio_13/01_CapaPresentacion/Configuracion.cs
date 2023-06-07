using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CapaPresentacion
{
    class Configuracion
    {
        public static string getConnectionString
        {
            get
            {
                return Properties.Settings.Default.ConnectionString;
            }
        }
    }
}

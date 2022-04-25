using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Diseño_Centrado_al_Usuario
{

    class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-7NUEEL8T ;DATABASE=DCU;" +
                "INTEGRATED SECURITY=true");
            cn.Open();
            return cn;
        }
        public static SqlConnection close()
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-7NUEEL8T ;DATABASE=DCU;" +
                "INTEGRATED SECURITY=true");
            cn.Close();
            return cn;
        }
    }
}

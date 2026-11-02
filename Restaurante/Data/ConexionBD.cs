using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;

namespace Restaurante.Data
{
    public class ConexionBD
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadenaConexion =
                ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            return new SqlConnection(cadenaConexion);
        }
    }
}

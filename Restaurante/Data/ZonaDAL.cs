
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class ZonaDAL
    {
        public List<Zona> ObtenerZonas()
        {
            List<Zona> lista = new List<Zona>();

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = @"SELECT IdZona, NombreZona, DescripcionZona
                                    FROM Zonas";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                conexion.Open();

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Zona zona = new Zona();

                        zona.IdZona = Convert.ToInt32(lector["IdZona"]);
                        zona.NombreZona = lector["NombreZona"].ToString();
                        zona.DescripcionZona = lector["DescripcionZona"].ToString();

                        lista.Add(zona);
                    }
                }
            }

            return lista;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class MesaDAL
    {
        public List<Mesa> ObtenerMesas()
        {
            List<Mesa> lista = new List<Mesa>();

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = @"
            SELECT M.IdMesa,
                   M.CapacidadMesa,
                   M.EstadoMesa,
                   M.IdZona,
                   Z.NombreZona
            FROM Mesas M
            INNER JOIN Zonas Z ON M.IdZona = Z.IdZona";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                conexion.Open();

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Mesa mesa = new Mesa();

                        mesa.IdMesa = Convert.ToInt32(lector["IdMesa"]);
                        mesa.CapacidadMesa = Convert.ToInt32(lector["CapacidadMesa"]);
                        mesa.EstadoMesa = lector["EstadoMesa"].ToString();
                        mesa.IdZona = Convert.ToInt32(lector["IdZona"]);
                        mesa.NombreZona = lector["NombreZona"].ToString();

                        lista.Add(mesa);
                    }
                }
            }

            return lista;
        }

        public void AgregarMesa(Mesa mesa)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = @"INSERT INTO Mesas
                            (CapacidadMesa, EstadoMesa, IdZona)
                            VALUES
                            (@Capacidad, @Estado, @Zona)";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@Capacidad", mesa.CapacidadMesa);
                comando.Parameters.AddWithValue("@Estado", mesa.EstadoMesa);
                comando.Parameters.AddWithValue("@Zona", mesa.IdZona);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void ActualizarMesa(Mesa mesa)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = @"UPDATE Mesas
                            SET CapacidadMesa = @Capacidad,
                                EstadoMesa = @Estado,
                                IdZona = @Zona
                            WHERE IdMesa = @IdMesa";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@IdMesa", mesa.IdMesa);
                comando.Parameters.AddWithValue("@Capacidad", mesa.CapacidadMesa);
                comando.Parameters.AddWithValue("@Estado", mesa.EstadoMesa);
                comando.Parameters.AddWithValue("@Zona", mesa.IdZona);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarMesa(int idMesa)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "DELETE FROM Mesas WHERE IdMesa = @IdMesa";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdMesa", idMesa);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

    }
}

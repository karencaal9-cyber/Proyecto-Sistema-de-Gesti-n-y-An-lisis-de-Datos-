
using System;
using Restaurante.Data;

namespace Restaurante
{
    public class PruebaConexion
    {
        public static void Probar()
        {
            MesaDAL mesaDAL = new MesaDAL();
            ZonaDAL zonaDAL = new ZonaDAL();

            var mesas = mesaDAL.ObtenerMesas();
            var zonas = zonaDAL.ObtenerZonas();

            System.Windows.Forms.MessageBox.Show(
                "Conexión correcta.\n" +
                "Mesas encontradas: " + mesas.Count + "\n" +
                "Zonas encontradas: " + zonas.Count
            );
        }
    }
}

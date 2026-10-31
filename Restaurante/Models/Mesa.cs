using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Mesa
    {
        public int IdMesa { get; set; }
        public int CapacidadMesa { get; set; }
        public string EstadoMesa { get; set; }
        public int IdZona { get; set; }
        public string NombreZona { get; set; }

        public Mesa()
        {
        }

        public Mesa(int idMesa, int capacidadMesa, string estadoMesa, int idZona)
        {
            IdMesa = idMesa;
            CapacidadMesa = capacidadMesa;
            EstadoMesa = estadoMesa;
            IdZona = idZona;
        }
    }

}

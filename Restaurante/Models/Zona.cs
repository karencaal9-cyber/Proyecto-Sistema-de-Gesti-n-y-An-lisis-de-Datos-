using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Zona
    {
        // Propiedades
        public int IdZona { get; set; }
        public string NombreZona { get; set; }
        public string DescripcionZona { get; set; }

        // Constructor vacío
        public Zona()
        {
        }

        // Constructor con parámetros
        public Zona(int idZona, string nombreZona, string descripcionZona)
        {
            IdZona = idZona;
            NombreZona = nombreZona;
            DescripcionZona = descripcionZona;
        }
    }
}

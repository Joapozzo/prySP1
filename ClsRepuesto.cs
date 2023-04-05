using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryClassVeterinaria
{
    class ClsRepuesto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public string Origen { get; set; }

        public string ObtenerDatos()
        {
            return "Codigo:  " + Codigo + " Nombre: " +
            Nombre + " Marca: " + Marca + " Precio: " + Precio + " Origen: " + Origen;

        }

    }
}

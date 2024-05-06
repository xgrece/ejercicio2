using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.models
{
    internal class Puesto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Constructor
        public Puesto(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
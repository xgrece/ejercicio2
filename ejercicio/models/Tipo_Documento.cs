using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.models
{
    internal class Tipo_Documento
    {
        public string Tipo { get; set; }

        // Constructor
        public Tipo_Documento(string tipo)
        {
            Tipo = tipo;
        }
    }
}
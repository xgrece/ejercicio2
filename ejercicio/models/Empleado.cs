using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio.models
{
    internal class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string numDocumento { get; set; }
        public Tipo_Documento tipo_Documento { get; set; } 
        public Puesto puesto { get; set; }
        //falta el constructor
}
}
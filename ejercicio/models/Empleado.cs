using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.models
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NumDocumento { get; set; }
        public Tipo_Documento TipoDocumento { get; set; }
        public Puesto Puesto { get; set; }

        // Constructor
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, string numDocumento, Tipo_Documento tipoDocumento, Puesto puesto)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            NumDocumento = numDocumento;
            TipoDocumento = tipoDocumento;
            Puesto = puesto;
        }
    }
}
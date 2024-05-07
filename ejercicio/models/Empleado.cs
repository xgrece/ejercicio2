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
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.NumDocumento = numDocumento;
            this.TipoDocumento = tipoDocumento;
            this.Puesto = puesto;
        }
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, string numDocumento, Tipo_Documento tipoDocumento, Puesto puesto)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            NumDocumento = numDocumento;
            TipoDocumento = tipoDocumento;
            Puesto = puesto;
        }
        public Empleado() { }
        public void MostrarInfo()
        {
            Console.WriteLine("Información del empleado:");
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento}");
            Console.WriteLine($"Número de documento: {NumDocumento}");
            Console.WriteLine($"Tipo de documento: {TipoDocumento.Tipo}");
            Console.WriteLine($"Puesto: {Puesto.Nombre}");
            Console.WriteLine($"Descripción del puesto: {Puesto.Descripcion}");
        }
    }
}
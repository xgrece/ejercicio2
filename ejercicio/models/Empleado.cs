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
        public Tipo_Documento tipoDocumento { get; set; }
        public Puesto puesto { get; set; }

        // Constructor
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, string numDocumento, Tipo_Documento tipoDocumento, Puesto puesto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.numDocumento = numDocumento;
            this.tipoDocumento = tipoDocumento;
            this.puesto = puesto;
        }
        public Empleado() { }

        public void MostrarInfo()
        {
            Console.WriteLine("informacion del empleado");
            Console.WriteLine($"nombre: {nombre} {apellido} ");
            Console.WriteLine($"fecha de nacimiento: {fechaNacimiento}");
            Console.WriteLine($"numero de documeto: {numDocumento}");
            Console.WriteLine($"tipo de documento: {tipoDocumento.tipo}");
            Console.WriteLine($"puesto: {puesto.nombre}");
            Console.WriteLine($"descripcion del puesto: {puesto.descripcion}");
        }

        //metodo para buscar un empleado por numero de doc
        public bool sosNumeroDoc(string numeroDocumento)
        {
            return this.numDocumento.ToLower().Trim() == numeroDocumento.ToLower().Trim();
        }
        public Empleado buscarEmpleadoXdoc(string numeroDocumento)
        {
            foreach (Empleado empleado in empleado)
            {
                Console.WriteLine($"comparando con el empleado {empleado.nombre} {empleado.apellido}");
                if (empleado.sosNumeroDoc(numeroDocumento))
                {
                    return empleado;
                }
            }
            return null; //si no se encuentra ningun empleado
        }
    }
}

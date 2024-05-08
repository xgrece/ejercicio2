using ejercicio.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{

    class Program
    {
        static void Main(string[] args)
        {
            //puestos
            Puesto puesto = new Puesto("Gerente", "Responsable de la gestión del personal");
            Puesto puesto1 = new Puesto("empleado","hace lo que le pide el gerente");
            //tipo doc
            Tipo_Documento tipoDoc = new Tipo_Documento("DNI");
            Tipo_Documento tipoDoc1 = new Tipo_Documento("DNI");
            //empleados
            Empleado empleado = new Empleado("Agustin", "Perez", new DateTime(1532, 3, 2), "12345678", tipoDoc, puesto);
            Empleado empleado1 = new Empleado("Mariano", "Fernandez", new DateTime(2000, 2, 1), "29111333", tipoDoc1, puesto1);
            //admin
            Admin admin = new Admin(empleado, puesto, tipoDoc);
            Admin admin1 = new Admin(empleado1, puesto1, tipoDoc1);

        }
    }
}

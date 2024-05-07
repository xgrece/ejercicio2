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
        // Crear una instancia de DateTime para la fecha de nacimiento

        Puesto puesto = new Puesto("Gerente", "Responsable de la gestión del personal");
        Tipo_Documento tipoDoc = new Tipo_Documento("DNI"); // Crear una instancia de Tipo_Documento

        Empleado empleado = new Empleado("Agustin", "Perez", new DateTime(1532, 3, 2), "12345678", tipoDocumento: tipoDoc, puesto);
        Admin admin = new Admin(empleado, puesto, tipoDoc);
        public Program(Empleado empleado)
        {
            this.empleado = empleado;
        }

    }
    }

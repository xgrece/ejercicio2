using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.models
{
    internal class Admin
    {
        public Empleado Empleado { get; set; }
        public Puesto Puesto { get; set; }
        public Tipo_Documento TipoDoc { get; set; }

        // Constructor
        public Admin(Empleado empleado, Puesto puesto, Tipo_Documento tipoDoc)
        {
            this.Empleado = empleado;
            this.Puesto = puesto;
            this.TipoDoc = tipoDoc;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    internal class Tarea
    {
        public string Nombre { get; set; }
        public string Estado { get; set; }

        public readonly DateTime FechaCreacion;

        public Tarea(string nombre, string estado)
        {
            Nombre = nombre;
            Estado = estado;
            FechaCreacion = DateTime.Now;
        }
    }
}


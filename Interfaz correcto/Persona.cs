using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_correcto
{
    internal class Persona
    {
        public Persona() { }
        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}

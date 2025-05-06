using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_correcto
{
    internal class Alumno:Persona
    {
        public Alumno() { }
        public Alumno(int matricula,string nombre,int edad)
            :base(nombre,edad)
        {
            this.Matricula = matricula;
        }

        public int Matricula {  get; set; }
    }
}

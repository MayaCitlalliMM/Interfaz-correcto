using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interfaz_correcto
{
    internal class Acciones : IAcciones
    {
        Alumno a = new Alumno();
        private List<Alumno> listalumnos = new List<Alumno>()
        {new Alumno (10010,"camilla",20) };

        public void Actualizar(int matricula6,int matriculaactualizar, string nombreactualizar, int edadactualizacion)
        {
            
            
                var objetliminar = listalumnos.Find(x => x.Matricula == matriculaactualizar);

               
                if (objetliminar != null)
                {
                    listalumnos.Remove(objetliminar);
                    listalumnos.Add(new Alumno(a.Matricula = matricula6,a.Nombre = nombreactualizar, a.Edad = edadactualizacion));
                }
        }

        public void Actualizar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }

        public void Agregar(int matricula, string nombre, int edad)
        {
            listalumnos.Add(new Alumno(a.Matricula = matricula, a.Nombre = nombre, a.Edad = edad));
        }

        public List<Alumno> Consultar()
        {
            return listalumnos;
        }

        public void Eliminar(int matricula, string nombre, int edad)
        {
            var objetoeliminar = listalumnos.FirstOrDefault(x => x.Matricula == matricula);
            if (objetoeliminar != null)
                listalumnos.Remove(objetoeliminar);
        }

        public void Eliminar(int matricula)
        {
            throw new NotImplementedException();
        }

        public void ExportaraExcel()
        {

        }
    }
}

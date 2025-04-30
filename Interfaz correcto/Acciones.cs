using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_correcto
{
    internal class Acciones : IAcciones
    {
        private List<Alumno> listalumnos = new List<Alumno>()
        {new Alumno (10010,"camilla",20) };

        public void Actualizar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }

        public void Agregar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> Consultar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }

        public void ExportaraExcel()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_correcto
{
    internal class Program
    {
        public enum Menu
        {
            Consultar = 1, Agregar, Eliminar,Actualizar,Exportar
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true)
            {
                switch(menu())
                {
                    case Menu.Consultar:
                        break;
                    case Menu.Agregar:
                        break;
                    case Menu.Eliminar:
                        break;
                    case Menu.Actualizar:
                        break;
                    case Menu.Exportar: 
                        break;
                }
            }
            
        }
        static Menu menu()
        {
            Console.WriteLine("1)Consultar");
            Console.WriteLine("2)Agregar");
            Console.WriteLine("3)Eliminart");
            Console.WriteLine("4)Actualizar");
            Console.WriteLine("5)Exportar");

            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}

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
                        var lista = acciones.Consultar();
                        foreach (var l in lista)
                        {
                            Console.WriteLine("----------------");
                            Console.WriteLine($"Nombre:{l.Nombre}");
                            Console.WriteLine($"Edad:{l.Edad}");
                            Console.WriteLine($"Matricula:{l.Matricula}");
                            Console.WriteLine("----------------");
                        }
                        break;
                    case Menu.Agregar:
                        Console.WriteLine("Nombre:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Edad");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Matricula");
                        int matricula = Convert.ToInt32(Console.ReadLine());
                        acciones.Agregar(matricula, nombre, edad);
                        break;
                    case Menu.Eliminar:
                        Console.WriteLine("Dame matricula a eliminar");
                        int matriculaeliminar = Convert.ToInt32(Console.ReadLine());
                        acciones.Eliminar(matriculaeliminar);
                        break;
                    case Menu.Actualizar:
                        Console.WriteLine("Dame matricula actualizar: ");
                        int matriculaactualizar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("dame  nombre: ");
                        string nombreactualizar = Console.ReadLine();
                        Console.WriteLine("dame  edad: ");
                        int edadactualizacion = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dame matricula: ");
                        int matricula6 = Convert.ToInt32(Console.ReadLine());
                        acciones.Actualizar(matricula6,matriculaactualizar,nombreactualizar,edadactualizacion);
                        break;
                    case Menu.Exportar: 
                        break;
                        default:
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

using System;
using System.Linq;

namespace wepsysPrueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Cuantos nombres ingresara");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            string[] nombres = new string[n];
            string[] amigos = new string[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese nombre "+i);
                nombres[i] = Console.ReadLine(); 

            }
            Console.WriteLine("------------------------------------------");
            for(int i = 0; i < n; i++)
            {
                if (nombre.Length == nombres[i].Length)
                {
                    amigos[i] = nombres[i];
                }
            }

            Console.WriteLine("Sus amigos son: ");
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine(amigos[i]);
            }
            Console.ReadKey();
           
        }
    }
}

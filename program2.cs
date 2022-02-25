using System;
using System.Collections.Generic;
using System.Linq;

namespace wepsysPrueba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la oracion");
            string oracion = Console.ReadLine();
            char[] palabra = oracion.ToCharArray();

            string[] palabraArray = new string[palabra.Length + 1];

            for (int i = 0; i < palabraArray.Length; i++)
            {

            }
            for (int i=0; i<palabra.Length; i++)
            {
                int cont = 0;
                palabraArray[cont] += palabra[i].ToString();
                palabraArray[cont] = palabraArray[cont].Trim();

                if (palabra[i] == ' ')
                {
                    palabraArray[cont] += palabraArray[cont].ToString().Length;
                    cont = cont+1;
                }
            }
            foreach (string c in palabraArray)
            {
                Console.WriteLine(c);
            }
        }
    }
}

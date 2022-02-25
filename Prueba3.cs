using System;

namespace wepsysprueba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 - (2 * 2));
            int[] Va = new int[2];
            int[] Vb = new int[2];

            Console.WriteLine("Ingrese vector A");
            Console.Write("X=");
            Va[0]= int.Parse(Console.ReadLine());
            Console.Write("Y=");
            Va[1]= int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese vector B");
            Console.Write("X=");
            Va[0] = int.Parse(Console.ReadLine());
            Console.Write("Y=");
            Va[1] = int.Parse(Console.ReadLine());

            int[] VaIn = new int[2];
            int[] VbIn = new int[2];

            for (int i = 0; i < 2; i++)
            {
                if (Va[i] >= 0)
                {
                    VaIn[i] = Va[i] - (Va[i] * 2);
                }
                if (Vb[i] >= 0)
                {
                    VbIn[i] = Vb[i] - (Vb[i] * 2);
                }

                if (Va[i] <= 0)
                {
                    VaIn[i] = Va[i] + (Va[i] * 2);
                }
                if (Vb[i] <= 0)
                {
                    VbIn[i] = Vb[i] + (Vb[i] * 2);
                }
            }

            int distancia = Convert.ToInt32(Math.Sqrt(((Va[0] + Vb[0]) ^ 2) + ((Va[1] + Vb[1]) ^ 2)));
            string suma = (Va[0] + Vb[0]) + "A " + " + " + (Va[1] + Vb[1]) + "B";
            string resta = (Va[0] - Vb[0]) + "A " + " - " + (Va[1] - Vb[1]) + "B";

            Console.WriteLine("La distancia es: " + distancia);
            Console.WriteLine("La suma de los vectores es: " + suma);
            Console.WriteLine("La resta de los vectores es: " + resta);
            Console.WriteLine("El vector inverso es: (" + VaIn[0] + ", " + VaIn[1] + ")  (" + VbIn[0] + ", " + VbIn[1] + ")");

            Console.ReadKey();
        }
    }
}

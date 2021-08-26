using System;

namespace AdivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int num = rnd.Next(101);
            int r;
            
            do
            {
                Console.WriteLine("Ingrese un numero del 0 al 100\n");
                r = Convert.ToInt32(Console.ReadLine());

                if (r < num)
                {
                    Console.WriteLine($"El numero {r} es menor al buscado\n");
                }

                if (r > num)
                {
                    Console.WriteLine($"El numero {r} es mayor al buscado\n");
                }

            } while (num != r);

            Console.WriteLine($"\nEncontraste el numero {num}");

        }
    }
}

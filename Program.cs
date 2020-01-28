using System;

namespace ejercicio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = 0, num = 0, multi = 0;
            Console.WriteLine("Bienvenido al buscador de multiplos de 3 sin los de 5");
            Console.WriteLine("Ingrese una cantidad de multiplos a buscar: ");
            try
            {
                num = int.Parse(Console.ReadLine());
            } catch (FormatException) { }
            Console.WriteLine("Imprimiendo los " + num + " primeros multiplos de 3 sin los de 5");
            while (i < num)
            {
                if (((multi + 3) % 5) != 0)
                {
                    multi += 3;
                    Console.WriteLine(multi);
                    i++;
                }
                else
                {
                    multi += 3;
                }
            }
            Console.WriteLine("Gracias por usar nuestros servicios, Ejecutenos pronto");
        }
    }
}
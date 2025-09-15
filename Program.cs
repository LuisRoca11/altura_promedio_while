// Se ingresan un conjunto de n alturas de personas por teclado. Mostrar la altura promedio de las personas.

using System;

namespace altura_promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int fin = 1;
            double promedio, altura, suma=0;
            int n=0;

            while (fin == 1)
            {
                Console.Write("Ingrese una altura: ");
                altura = double.Parse(Console.ReadLine());

                n = n + 1;
                suma = suma + altura;
                promedio = suma / n;

                Console.Write("Finalizar y mostrar promedio(si=0 no=1): ");
                fin = int.Parse(Console.ReadLine());
                if (fin==0)
                {
                    Console.WriteLine($"El promedio de las alturas es: {promedio}");
                }
            }
            
            Console.ReadKey();


        }
    }
}

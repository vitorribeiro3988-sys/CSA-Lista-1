using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int diagonal;

            Console.WriteLine("Digite o valor da diagonal:");
            diagonal = int.Parse(Console.ReadLine());

            // Fórmula: (Diagonal * Diagonal) / 2
            int areaTotal = (diagonal * diagonal) / 2;

            Console.WriteLine("A área do quadrado é: {0}", areaTotal);
            
            Console.ReadLine();
        }
    }
}

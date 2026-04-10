using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int aresta;

            Console.WriteLine("Digite o valor da aresta:");
            aresta = int.Parse(Console.ReadLine());

            int areaTotal = aresta * aresta;

            Console.WriteLine("A área do quadrado é: {0}", areaTotal);
            
            Console.ReadLine();
        }
    }
}

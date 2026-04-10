using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseTriangulo;
            int alturaTriangulo;

            Console.WriteLine("Digite o valor da base:");
            baseTriangulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura:");
            alturaTriangulo = int.Parse(Console.ReadLine());

            int areaTotal = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine("A área do triângulo é: {0}", areaTotal);

            Console.ReadLine();
        }
    }
}

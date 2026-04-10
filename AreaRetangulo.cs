using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA;
            int valorB;

            Console.WriteLine("Cálculo da área de um retângulo");
            
            Console.WriteLine("Digite a base:");
            valorA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura:");
            valorB = int.Parse(Console.ReadLine());

            int areaTotal = valorA * valorB;

            Console.WriteLine("O total da área é: {0}", areaTotal);
            
            Console.ReadLine();
        }
    }
}

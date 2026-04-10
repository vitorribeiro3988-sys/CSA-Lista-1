using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto número:");
            n4 = int.Parse(Console.ReadLine());

            int media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("A média final é: {0}", media);

            Console.ReadLine();
        }
    }
}

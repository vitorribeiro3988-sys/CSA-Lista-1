using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            // A média geométrica é a raiz quadrada da multiplicação dos dois valores
            double resultado = Math.Sqrt(valor1 * valor2);

            Console.WriteLine("A média geométrica é: {0}", resultado);
            
            Console.ReadLine();
        }
    }
}

using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double milhas;

            Console.WriteLine("Digite a quantidade de milhas marítimas:");
            milhas = double.Parse(Console.ReadLine());

            // 1 milha = 1852 metros. Dividindo por 1000 temos o valor em km (1.852)
            double quilometros = milhas * 1.852;

            Console.WriteLine("{0} milhas marítimas equivalem a {1} km", milhas, quilometros);
            
            Console.ReadLine();
        }
    }
}

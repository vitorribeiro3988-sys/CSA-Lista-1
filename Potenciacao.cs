using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            Console.WriteLine("Digite o valor de X (base):");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y (expoente):");
            y = double.Parse(Console.ReadLine());

            // Math.Pow realiza o cálculo de potência
            double resultado = Math.Pow(x, y);

            Console.WriteLine("{0} elevado a {1} é igual a: {2}", x, y, resultado);
            
            Console.ReadLine();
        }
    }
}

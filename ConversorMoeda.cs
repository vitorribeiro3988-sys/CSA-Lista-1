using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao;
            double quantidadeDolar;
            double valorReais;

            Console.WriteLine("Digite a cotação atual do dólar:");
            cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de dólares:");
            quantidadeDolar = double.Parse(Console.ReadLine());

            valorReais = cotacao * quantidadeDolar;

            Console.WriteLine("O valor correspondente em Reais é: R$ {0:F2}", valorReais);
            
            Console.ReadLine();
        }
    }
}

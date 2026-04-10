using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, p4, p5;
            double total, valorPago, troco;

            Console.WriteLine("Digite o valor do produto 1:");
            p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 2:");
            p2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 3:");
            p3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 4:");
            p4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 5:");
            p5 = double.Parse(Console.ReadLine());

            total = p1 + p2 + p3 + p4 + p5;

            Console.WriteLine("\nTotal: {0:F2}", total);

            Console.WriteLine("Digite o valor pago:");
            valorPago = double.Parse(Console.ReadLine());

            troco = valorPago - total;

            Console.WriteLine("Troco a devolver: R$ {0:F2}", troco);

            Console.ReadLine();
        }
    }
}

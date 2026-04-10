using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;

    Console.Write("Digite a temperatura em graus Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            // Realiza a conversão usando a fórmula padrão
            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine("{0}°C equivalem a {1}°F", celsius, fahrenheit);
            
            Console.ReadLine();
        }
    }
}

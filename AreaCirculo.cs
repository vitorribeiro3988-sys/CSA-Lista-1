using System;

namespace ExerciciosAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double diametro;
            double raio;
            double area;

            Console.WriteLine("Digite o valor do diâmetro:");
            diametro = double.Parse(Console.ReadLine());

            // O raio é metade do diâmetro
            raio = diametro / 2;

            // Math.PI fornece o valor de Pi e Math.Pow eleva o raio ao quadrado
            area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo é: {0:F2}", area);
            
            Console.ReadLine();
        }
    }
}

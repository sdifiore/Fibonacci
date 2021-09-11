using System;
using System.Globalization;

namespace Fibonacci
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Cálculo da série de Fibonacci");
            Console.WriteLine("=============================");

            Console.Write("Quantos elementos deseja calcular? ");
            int elementos = int.Parse(Console.ReadLine());

            double[] serie = new double[elementos];
            serie = Calculo.Ate(elementos);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=============================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            foreach (double item in serie)
                Console.Write($"{ item.ToString("#,##0", CultureInfo.CurrentCulture) }  ");
           
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=============================");

            Console.WriteLine();
            Console.WriteLine("Mais sobre formatação de números em:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings");
            Console.ResetColor();
        }
    }
}

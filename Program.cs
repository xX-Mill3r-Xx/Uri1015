using System;
using System.Globalization;

namespace Uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programa que calcula a distancia entre dois pontos no plano carteziano*/

            double x1, x2, y1, y2;
            Console.Write("Informe dois valores para P-1: ");
            string[] valores = Console.ReadLine().Split(' ');
            x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            Console.Write("Informe dois valores para P-2: ");
            valores = Console.ReadLine().Split(' ');
            x2 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1,2.0));
            Console.WriteLine($"A distancia percorrida foi: {distancia.ToString("F4", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}

using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, horasTrabalhadas;
            double valorPorHora, salarioFinal;

            //entrada

            X = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //processamento

            salarioFinal = valorPorHora * horasTrabalhadas;
 

            //saída

            Console.WriteLine("NUMBER = " + X);
            Console.WriteLine("SALARY = U$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("NUMBER = " + X);
            Console.WriteLine("SALARY = U$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();

        }
    }
}

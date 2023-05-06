using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaqvkaZaKoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter how many numbers you want: ");
            int n = int.Parse(Console.ReadLine());
            SquareRootCalculator calculator = new SquareRootCalculator();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                double squareRoot = calculator.CalculateSquareRoot(number);
                Console.WriteLine($"The squareroot of [{number}] is [{squareRoot}]");
            }
        }
    }
}

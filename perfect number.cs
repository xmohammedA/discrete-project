using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The lowest number");

            double min = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter The The biggest number");

            double max = double.Parse(Console.ReadLine());

            for (double i = min; i < max; i++)
            {
                double result = perfect(i);
                if (i == result)
                {
                    Console.WriteLine(i + " is a perfect number");
                }
            }

            Console.ReadKey();
        }
        public static double perfect(double m)
        {
            double sum = 0;
            for (double a = 1; a < m; a++)
            {
                if (m % a == 0)
                {
                    sum = sum + a;
                }

            }

            return sum;

        }
    }
}

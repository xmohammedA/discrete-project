using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lowest number");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the highest number");
            int max = int.Parse(Console.ReadLine());

            
            while (min <= max)
            {
                int n = 0;
                int d = 2;
                if (min == 1)
                {
                    min++;
                    continue;
                }
                while (d < min)
                {

                    if (min % d == 0)
                    {
                        n++;
                    }
                    d++;

                }
                if (n == 0)
                {
                    Console.WriteLine("the resilt = " + min);
                }


                min++;
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class FizzBuzz
    {
        public void runFizzBuzz()
        {
            for (int counter = 1; counter <= 101; counter++)
            {
                if (counter % 3 == 0 && counter % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (counter % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else if (counter % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}

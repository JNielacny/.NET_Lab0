using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        int max = 0;
        public FizzBuzz(int upmax)
        {
            this.max = upmax;
        }
        public void Display() { 
        for(int i=0; i<max; i++)
        {

                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FIZZBUZZ");
                    }
                    else
                    {
                        Console.WriteLine("FIZZ");
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");

                }
                else {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

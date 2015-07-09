using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_9_15_ExperIT_Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            for(int x=1; x<=100;x++)
            {
                //checks to see if x is divisable by 3 and 5
                int test3 = x % 3;
                int test5 = x % 5;
              
                //test that test3 and test5 return 0 making them both divisable by 3 and 5 or 15 then breaks from the loop
                if (test3 == 0 && test5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if( test3 == 0 )//if divisible by only 3
                {
                    Console.WriteLine("Fizz");
                }
                 else if(test5 == 0)//if divisable by only 5
                {
                    Console.WriteLine("Buzz");
                }
                else//prints all the remaining numbers
                {
                    Console.WriteLine(x);
                }
            }

            Console.Read();

        }
    }
}

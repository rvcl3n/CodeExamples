using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeExamples
{
    class FizzBuzzTask
    {
        //My implementation
        public static void FizzBuzz1()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }  
            }
        }

        //Better implementation
        public static void FizzBuzz2()
        {
            for (int i = 1; i <= 100; i++)
            {
                string res = "";
                
                if(i % 3 == 0)
                {
                    res += "Fizz";
                }
                if(i % 5 == 0)
                {
                    res += "Buzz";
                }

                if(res.Length == 0)
                {
                    Console.WriteLine(i);
                }
                else 
                {
                    Console.WriteLine(res);
                }
            }
        }

        //One line implementation, but I didn't get how ;; works
        public static void FizzBuzz3()
        {
            Enumerable.Range(1, 100).ToList().ForEach(i => Console.WriteLine($"{(i % 3 * i % 5 == 0 ? 0 : i):#;}{i % 3:;;Fizz}{i % 5:;;Buzz}"));

        }
    }
}

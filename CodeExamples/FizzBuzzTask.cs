using System;
using System.Collections.Generic;
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
    }
}

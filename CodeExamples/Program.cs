﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adapter call
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());

            //Array Sum up
            int[] array = {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(ArrayOperations.SumUpArray(array));

            //Circle class with Func
            Circle c = new Circle();
            //Func: two versions
            ///Func<double, double> func = delegate (double x) { return x * 3.14; };
            Func<double, double> func = res => res*3.14;
            Console.WriteLine(c.Calculate(func));

            //Reverve the words order in the sentence
            Console.WriteLine(StringOperations.ReverseSentence("Test my function"));

            Console.ReadKey();
        }
    }
}

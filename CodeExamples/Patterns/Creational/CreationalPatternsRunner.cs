using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExamples.Patterns.Creational
{
    class CreationalPatternsRunner
    {
        public static void Run()
        {
            //FabricMethod call
            new Client().Main();

            //Singleton call
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}

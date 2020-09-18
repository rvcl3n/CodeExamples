using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExamples.Patterns.Creational
{
    class CreationalPatternsRunner
    {
        public static void Run()
        {
            //FactoryMethod call
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientFactoryMethod.ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientFactoryMethod.ClientCode(new ConcreteCreator2());

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

            //AbstractFactory call
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientAbstractFactory.ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientAbstractFactory.ClientMethod(new ConcreteFactory2());
        }
    }
}

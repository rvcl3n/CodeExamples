using System;
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


            //Facade call
            FacadeExample facade = new FacadeExample();

            facade.MethodA();
            facade.MethodB();

            //Decorator call
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);

            //Proxy call
            ClientForProxy clientForProxy = new ClientForProxy();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            clientForProxy.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            clientForProxy.ClientCode(proxy);

            //Bridge call
            ClientForBridge clientForBridge = new ClientForBridge();

            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            clientForBridge.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            clientForBridge.ClientCode(abstraction);

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

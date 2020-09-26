using System;

namespace CodeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine(Anagram.CountWords("test estt eye yee eey"));

            //Console.WriteLine(Math.Round(6.5));
            //Console.WriteLine(Math.Round(11.5));

            FizzBuzzTask.FizzBuzz();

            Console.ReadKey();
        }
    }
}

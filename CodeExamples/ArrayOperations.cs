using System.Linq;

namespace CodeExamples
{
    class ArrayOperations
    {
        public static int SumUpArray(int[] array)
        {
            return array.Where(i => i % 2 == 0).Sum(i => i);
        }
    }
}

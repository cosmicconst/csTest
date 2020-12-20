using System;
using System.Collections;

namespace Testing
{
    class Program1
    {
        public static void Main()
        {
            foreach (int j in AddMath(10, 2))
            {
                Console.WriteLine("Number: {0}\n", j);
            }
        }

        public static IEnumerable AddMath(int times, int add)
        {
            for (int i = 0; i < times; i++)
            {
                yield return i + add;
            }
        }
    }
}
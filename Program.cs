using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.2, 1.3, 1.4, 1.5 };
            toprInt(intArray);
            toprDouble(doubleArray);
        }
        public static void toprInt(int[] inputArray)
        {
            foreach (int item in inputArray)
            {
                Console.WriteLine(item);
            }
        }
        public static void toprDouble(double[] inputArray)
        {
            foreach (int item in inputArray)
            {
                Console.WriteLine(item+"\n");
            }
        }

    }
}

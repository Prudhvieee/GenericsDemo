using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.2, 1.3, 1.4, 1.5 };
            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
        }
    }
}
public class PrintArray<T>
{
    private T[] inputArray;
    public PrintArray(T[] inputArray)
    {
        this.inputArray = inputArray;
    }
    public void toPrint()
    {
        foreach (var item in inputArray)
        {
            Console.WriteLine(item);
        }
    }
}
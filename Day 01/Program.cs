using System;

namespace Day_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toTest = { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };

            int toPrint = Increase.GetCountIncreases(toTest);
            Console.WriteLine(toPrint);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Day_03
{
    class Program
    {
        static void Main(string[] args)
        {
            HandelInputs inputReader = new HandelInputs();

            inputReader.ReadFiles();
            List<String> data = inputReader.TestData;

            foreach (string number in data)
            {
                Console.WriteLine (number);
            }

            // Console.WriteLine(inputReader.SplitData()[0]);
        }
    }
}

using System;

namespace Day_04
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessInputs GetData = new ProcessInputs();
            GetData.ReadFiles();

            foreach (String line in GetData.TestData)
            {
                Console.WriteLine (line);
            }

            //look at number called
            //identify locations on boards
            //check Win condition
            //math on end.
        }
    }
}

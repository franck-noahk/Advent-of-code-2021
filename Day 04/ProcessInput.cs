using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Day_04
{
    public class ProcessInputs
    {
        public List<string> InputData { get; set; }

        public List<string> TestData { get; set; }

        public ProcessInputs()
        {
            this.InputData = new List<string>();
            this.TestData = new List<string>();
        }

        public void ReadFiles()
        {
            // Read the file and display it line by line.
            foreach (var line in System.IO.File.ReadLines("./input.txt"))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    // Console.WriteLine (line);
                    InputData.Add (line);
                }
            }
            foreach (var line in System.IO.File.ReadLines("./sample.txt"))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    TestData.Add (line);
                }
            }
        }
    }
}

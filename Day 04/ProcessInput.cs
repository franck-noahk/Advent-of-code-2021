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

        public void ReadFiles()
        {
            // Read the file and display it line by line.
            foreach (string line in System.IO.File.ReadLines("./input.txt"))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    InputData.Add (line);
                }
            }
            foreach (string line in System.IO.File.ReadLines("./sample.txt"))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    TestData.Add (line);
                }
            }
        }
    }
}

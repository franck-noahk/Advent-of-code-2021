using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Day_03
{
    public class HandelInputs
    {
        public List<string> InputData { get; set; }

        public List<string> TestData { get; set; }

        public HandelInputs()
        {
            InputData = new List<string>();
            TestData = new List<string>();
        }

        public void ReadFiles()
        {
            int counter = 0;

            // Read the file and display it line by line.
            foreach (string line in System.IO.File.ReadLines("./Input.txt"))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    InputData.Add (line);
                }
            }
            foreach (string line in System.IO.File.ReadLines("./Test.txt"))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    TestData.Add (line);
                }
            }
        }
    }
}

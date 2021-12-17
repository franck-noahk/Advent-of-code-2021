using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_03
{
    class Program
    {
        static void Main(string[] args)
        {
            HandelInputs inputReader = new HandelInputs();

            inputReader.ReadFiles();
            List<String> data = inputReader.InputData;

            string gama = getSignficantBit(data);
            string epsilon = getLeastSignificantBit(data);

            Console.WriteLine($"Gama: {gama}\tEpsilon: {epsilon}");
        }

        private static string getSignficantBit(List<string> data)
        {
            string toReturn = "";
            int isOne = 0;
            char[] charArr;
            char[] sample = data.First<string>().ToCharArray();
            for (int i = 0; i < sample.Length; i++)
            {
                foreach (string set in data)
                {
                    charArr = set.ToCharArray();
                    if (charArr[i] == '1')
                    {
                        isOne++;
                    }
                    else
                    {
                        isOne--;
                    }
                }
                if (isOne > 0)
                {
                    toReturn += "1";
                }
                else
                {
                    toReturn += "0";
                }
                isOne = 0;
            }

            return toReturn;
        }

        private static string getLeastSignificantBit(List<string> data)
        {
            string toReturn = "";

            string toInvert = getSignficantBit(data);

            char[] charArr = toInvert.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '0')
                {
                    toReturn += "1";
                }
                else
                {
                    toReturn += "0";
                }
            }

            return toReturn;
        }
    }
}

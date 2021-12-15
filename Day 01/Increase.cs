using System;

namespace Day_01
{
    public static class Increase
    {
        public static int GetCountIncreases(int[] arr){
            int toReturn = 0;

            if (arr.Length <= 1)
            {
                return toReturn;    
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i-1])
                {
                    toReturn += 1;
                }
            }

            return toReturn;
        }
    
        public static int GetSumsIncreases(int[] arr, int spacingSize){
            int toReturn = 0;
            int sum = 0;
            int previousSum = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
              
                sum = 0;
                for (int j = 0; j < spacingSize; j++)
                {
                   if (!(i + j >= arr.Length))
                    {
                        sum += arr[i+j];
                    }
                }
                if(sum > previousSum)
                    toReturn += 1;

                previousSum = sum;      
            }

            return toReturn;
        }
    }
}
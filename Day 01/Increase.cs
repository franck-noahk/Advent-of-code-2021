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
    }
}
using System;

namespace ProductOfEverythingButI
{
    public class Class1
    {
        public static int[] CalculateProductOfEverythingButI(int[] input)
        {
            int[] output = new int[input.Length];

            for(int i = 0; i <input.Length; i++)
            {
                output[i] = 1;
                for (int j = 0; j < input.Length; j++)
                {
                    if(i!=j)
                    {
                        output[i] = input[j] * output[i];
                    }
                }
            }
            return output;
        }
    }
}

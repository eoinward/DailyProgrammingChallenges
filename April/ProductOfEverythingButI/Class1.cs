using System;

namespace ProductOfEverythingButI
{
    public class Class1
    {
        /// <summary>
        /// No division but O(n2) 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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

        /// <summary>
        /// division two loops but not nested so O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] CalculateProductOfEverythingButIDivision(int[] input)
        {

            int[] output = new int[input.Length];

            int total = 1;

            for(int i = 0; i < input.Length; i++)
            {
                total = input[i] * total;
            }

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = total/input[i];
            }

            return output;
        }

        public static int[] CalculateProductOfEverythingButIPreAnPost(int[] input)
        {

            int[] output = new int[input.Length];

            int total = 1;

            for (int i = 0; i < input.Length; i++)
            {
                total = input[i] * total;
            }

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = total / input[i];
            }

            return output;
        }


    }
}

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
            int[] pre = Pre(input);
            int[] post = Post(input);

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    output[i] = post[i + 1];
                }
                else if (i == input.Length - 1)
                {
                    output[i] = pre[i - 1];
                }
                else
                {
                    output[i] = pre[i - 1] * post[i + 1];
                }
            }
            return output;
        }

        public static int[] Pre(int[] input)
        {
            int[] pre = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    pre[i] = input[i];
                }
                else
                {
                    pre[i] = pre[i-1] * input[i];
                }
            }
            return pre;
        }

        public static int[] Post(int[] input)
        {
            int[] post = new int[input.Length];
            for ( int i = input.Length - 1; i > -1; i--)
            {
                if (i == input.Length -1)
                {
                    post[i] = input[i];
                }
                else
                {
                    post[i] = input[i] * post[i + 1];
                }
            }
            return post;
        }


    }
}

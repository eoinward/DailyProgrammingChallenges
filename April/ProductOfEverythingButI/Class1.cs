using System;

/// <summary>
/// Good morning! Here's your coding interview problem for today.
///This problem was asked by Uber.
///Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
///For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be[2, 3, 6].
///Follow-up: what if you can't use division?
/// </summary>
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


        /// <summary>
        /// for the Unit test [1, 2, 3, 4, 5] input
        /// pre will be [1, 2, 6, 24, 120]
        /// post will be [120, 120, 60, 20, 5]
        /// And for i you will multiple the pre i-1 and the post i+1 to get the i value for the output
        /// Specail cases on the end where there is no multiple
        /// 
        /// 3 loops but none are nested to its 0(n)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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

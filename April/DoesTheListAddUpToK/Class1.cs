using System;
using System.Collections.Generic;

namespace DoesTheListAddUpToK
{
    public class Class1
    {
        public static bool AdditionOfToNumbersInThisListEqualsK(List<int> list, int k)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (int number in list)
            {
                int required = (k - number);

                if (dictionary.ContainsKey(number))
                {
                    if (dictionary[number] == required)
                        return true;
                }

                dictionary.Add(required, number);
            }
            return false;
        }

        public static bool FlagArraySolution(int[] list, int k)
        {
            bool[] boolArray = new bool[k];

            foreach (int number in list)
            {
                int required = (k - number);

                if (boolArray[number])
                {
                        return true;
                }

                boolArray[required] = true;
            }
            return false;
        }

        public static bool AdditionOfToNumbersInThisListEqualsK(int[] array, int k)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int required = (k - array[i]);
                if (required == k / 2)
                {
                    if (CountOfXinArray(required, array) > 1)
                    {
                        return true;
                    }
                    return false;
                }

                if (CountOfXinArray(required, array) > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static int CountOfXinArray(int x, int[] array)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (x == array[j])
                    count++;
            }
            return count;
        }


        public static bool ArunSolution(int[] array, int k)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int required = (k - array[i]);
                for (int j = 0; j < array.Length; j++)
                {
                    if (required == array[j] && i != j) //takes care of half
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public static bool NathanSolution(int[] array, int k)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == k) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool GetTwoNumbersAddsUpToParam2(int[] numbers, int number)

        {
            int loops = 0;
            int firstIndex = 0;
            int lastIndex = numbers.Length - 1;

            while (loops < numbers.Length && firstIndex < lastIndex)
            {
                if (numbers[firstIndex] + numbers[lastIndex] == number)
                {
                    return true;
                }

                if (numbers[firstIndex] + numbers[firstIndex + 1] == number)
                {
                    return true;
                }

                if (numbers[lastIndex] + numbers[lastIndex - 1] == number)
                {
                    return true;
                }

                loops++;
            }
            return false;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 10, 15, 3, 6 };
            int k = 17;

            Console.WriteLine(AdditionOfToNumbersInThisListEqualsK(list, k));
            Console.ReadLine();
        }

      
    }
}

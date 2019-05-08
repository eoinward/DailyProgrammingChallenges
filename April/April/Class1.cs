using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April
{
    public static class FunctionOne
    {
        public static bool AdditionOfToNumbersInThisListEqualsK(List<int> list, int k)
        {
            foreach (int number in list)
            {
                int required = (k - number);
                if (list.Contains(required))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

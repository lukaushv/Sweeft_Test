using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft_test
{
    public class Algorithms
    {
        public static bool IsPalindrome(string str)
        {
            string first = str.Substring(0, str.Length/2);

            string second = string.Empty;
            for (int i = str.Length-1; i >= str.Length / 2; i--)
            {
                second+= str.ElementAt(i);
            }

            return first.Equals(second);
        }

        public static int MinSplit(int amount)
        {
            
            int coin = 0;
            int temp = 0;
            if (amount == 0) return coin;

            temp = amount / 50;
            coin += temp;
            amount %= 50;

            temp = amount / 20;
            coin += temp;
            amount %= 20;

            temp = amount / 10;
            coin += temp;
            amount %= 10;

            temp = amount / 5;
            coin += temp;
            amount %= 5;

            temp = amount / 2;
            coin += temp;
            amount %= 2;

            temp = amount;
            coin += temp;
            amount -= temp;

            return coin;
        }


        public static int NotContains(int[] array)
        {
            if(array.Length==0) return 0;

            int res = 1;
            int[] workarr = array.Where(x => x > 0).Distinct().OrderBy(x => x).ToArray();

            if (workarr[0] == 1)
            {
                if(workarr.Length == workarr[workarr.Length - 1])
                {
                    res = workarr.Last();
                }
                else
                {
                    for(int i = 1;i<workarr.Length;i++)
                    {
                        if(!workarr.Contains(i))
                        {
                            res = i;
                            break;
                        }
                    }
                }
            }
            return res;
        }


        public static bool IsProperly(string seq)
        {

            var stack = new Stack<char>();
            char[] chars = seq.ToCharArray();
            foreach (var c in chars)
            {
                if (c is '(')
                {
                    stack.Push(c);
                    continue;
                }
                if (c is ')')
                {
                    if (!stack.TryPop(out char last) || last != '(')
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        public static int CountVariants(int stairCount)
        {
            if (stairCount == 0) { return 0; }

            else
            {
                int[] stepcount = new int[stairCount+1];
                stepcount[0] = 1;
                stepcount[1] = 1;
                for(int i = 2; i<=stairCount; i++)
                {
                    stepcount[i] = stepcount[i-2] + stepcount[i-1];
                }
                return stepcount[stairCount];
            }
        }
    }
}

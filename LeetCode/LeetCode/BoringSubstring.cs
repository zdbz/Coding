using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://www.scaler.com/academy/mentee-dashboard/class/70461/assignment/problems/5550?navref=cl_tt_nv
    internal class BoringSubstring
    {
        public int solve(string A)
        {
            int highFirst = int.MinValue, lowFirst = int.MaxValue, highSecond = int.MinValue, lowSecond = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                {
                    if (A[i] > highFirst)
                        highFirst = A[i];
                    if (A[i] < lowFirst) 
                        lowFirst = A[i];
                }
                else
                {
                    if (A[i] > highSecond)
                        highSecond = A[i];
                    if (A[i] < lowSecond)
                        lowSecond = A[i];
                }
            }

            Console.WriteLine($"{lowFirst}, {highFirst}, {lowSecond}, {highSecond}");
            if ((lowFirst + 1 != lowSecond && lowFirst - 1 != lowSecond) || (lowFirst + 1 != highSecond && lowFirst - 1 != highSecond))
            {
                return 1;
            }

            if ((highFirst + 1 != lowSecond && highFirst - 1 != lowSecond) || (highFirst + 1 != highSecond && highFirst - 1 != highSecond))
            {
                return 1;
            }
            return 0;
            //return (Math.Abs(minOdd - minEven) > 1 || Math.Abs(maxOdd - minEven) > 1 || Math.Abs(minOdd - maxEven) > 1 || Math.Abs(maxOdd - maxEven) > 1) ? 1 : 0;

        }
    }
}

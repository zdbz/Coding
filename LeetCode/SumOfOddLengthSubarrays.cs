using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SumOfOddLengthSubarrays
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int arrSum = 0, mainSum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                arrSum += arr[i];
            }
            if(arr.Length % 2 != 0)
            {
                mainSum = 2 * arrSum;
            }
            else
            {

                //TODO
            }
            return mainSum;
        }
    }
}

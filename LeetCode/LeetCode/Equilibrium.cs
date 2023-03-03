using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            int[] suffixArray = new int[nums.Length];
            int[] prefixArray = new int[nums.Length];
            int n = nums.Length;
            prefixArray[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                prefixArray[i] = nums[i] + prefixArray[i - 1];
            }

            suffixArray[n - 1] = nums[n - 1];
            for (int i = n-2; i >= 0; i--)
            {
                suffixArray[i] = nums[i] + suffixArray[i + 1];
            }

            if (suffixArray[1] == 0)
                return 0;

            if (prefixArray[n - 2] == 0)
                return n - 1;


            for (int i = 1; i < n-1; i++)
            {
                if(prefixArray[i-1] == suffixArray[i + 1])
                {
                    return i;
                }
            }

            return -1;

        }
    }
}

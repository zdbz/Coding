using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class FindMiddleIndx
    {
        public int FindMiddleIndex(int[] nums)
        {
            int arraySum = 0;
            foreach (var item in nums)
            {
                arraySum += item;
            }
            int sum = 0;
            if(arraySum - nums[0] == 0)
            {
                return 0;
            }
            for(int i =1;i<nums.Length-1;i++)
            {
                sum += nums[i-1];
                if (sum == arraySum - (nums[i] + sum))
                    return i;
            }
            if(arraySum - nums[nums.Length-1] == 0)
            {
                return 0;
            }
            return 0;
        }
    }
}

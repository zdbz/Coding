using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxContiguousSubArray
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/55129/assignment/problems/56/submissions
        public int maxSubArray(List<int> A)
        {
            int sum = 0, ans = A[0];
            for (int i = 0; i < A.Count; i++)
            {
                sum = sum + A[i];
                ans = Math.Max(ans, sum);
                if(sum < 0)
                {
                    sum = 0;
                }
            }
            return ans;
        }
    }
}

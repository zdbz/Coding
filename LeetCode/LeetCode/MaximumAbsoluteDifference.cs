using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaximumAbsoluteDifference
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/55129/assignment/problems/356?navref=cl_tt_nv
        public int maxArr(List<int> A)
        {
            int maxAi = int.MinValue, minAj = int.MaxValue, maxAi2 = int.MinValue, minAj2 = int.MaxValue;
            for (int i = 0; i < A.Count; i++)
            {
                maxAi = Math.Max(maxAi, A[i] + i);
                minAj = Math.Min(minAj, A[i] + i);
                maxAi2 = Math.Max(maxAi2, A[i] - i);
                minAj2 = Math.Min(minAj2, A[i] - i);
            }

            return Math.Max((maxAi - minAj), (maxAi2 - minAj2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ContinousSumQuery
    {
        public List<int> solve(int A, List<List<int>> B)
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < A; i++)
            {
                arr.Add(0);
            }
            for (int i = 0; i < B.Count; i++)
            {
                var startIndex = B[i][0] -1;
                var endIndex = B[i][1] - 1;
                var money = B[i][2];
                arr[startIndex] = arr[startIndex] + money;
                if(endIndex < arr.Count - 1)
                    arr[endIndex+1] -= money;
            }

            for (int i = 1; i < arr.Count; i++)
            {
                arr[i] += arr[i - 1];
            }
            return arr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class PartitionArray
    {
        public bool CanThreePartsEqualSum(int[] arr)
        {
            int arrSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arrSum += arr[i];
            }
            if(arrSum%3 !=0)
            return false;
            int requiredSum = arrSum / 3;
            int count = 0;
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
                if(sum == requiredSum)
                {
                    count++;
                    sum = 0;
                }
            }
            if (count == 3)
                return true;
            return false;
        }
    }
}

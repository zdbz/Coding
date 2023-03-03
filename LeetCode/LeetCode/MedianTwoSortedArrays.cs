using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MedianTwoSortedArrays
    {
        //https://leetcode.com/problems/median-of-two-sorted-arrays/
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] arr = new int[nums1.Length + nums2.Length];
            int countNums1 = 0, countNums2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
               if(countNums1 == nums1.Length)
                {
                    arr[i] = nums2[countNums2];
                    countNums2++;
                }
                if(countNums2 == nums2.Length)
                {
                    arr[i] = nums1[countNums1];
                    countNums1++;
                }
                else if(nums1[countNums1] < nums2[countNums2])
                {
                    arr[i] = nums1[countNums1];
                    countNums1++;
                }
                else
                {
                    arr[i] = nums2[countNums2];
                    countNums2++;
                }
            }
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            if(arr.Length % 2 != 0)
            {
                return arr[arr.Length / 2];
            }
            else
            {
                int median = arr[arr.Length / 2] + arr[(arr.Length / 2) - 1];
                return median / 2;
            }
          
        }
    }
}

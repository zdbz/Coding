using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://www.scaler.com/academy/mentee-dashboard/class/37795/assignment/problems/204?navref=cl_tt_lst_nm
    internal class SortedInsertedPosition
    {
        public int searchInsert(List<int> A, int B)
        {
            int low = 0, high = A.Count, mid = 0;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (A[mid] == B)
                {
                    return mid;
                }
                else if (B > A[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            if (B > A[mid])
                return mid + 1;
            return mid;
        }
    }
}

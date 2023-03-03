using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
     class isAlNum
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/27558/assignment/problems/10695?navref=cl_tt_nv
        public int solve(List<char> A)
        {
            foreach (var item in A)
            {
                if (!((item >= 'a' && item <= 'z') || (item >= 'A' && item <= 'Z') || (item >= '0' && item <= '9')))
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/ways-to-make-a-fair-array/
    class SpecialIndex
    {
        public int WaysToMakeFair(int[] A)
        {
            if (A.Length < 2)
            {
                return 1;
            }
            int[] Aodd = new int[A.Length];
            int[] Aeven = new int[A.Length];
            int n = A.Length, count = 0 ;
            Aeven[0] = Aeven[1] = A[0];
            Aodd[0] = 0;
            Aodd[1] = A[1];
            for (int i = 2; i < A.Length; i++)
            {
                if(i % 2 == 0)
                {
                    Aodd[i] = Aodd[i - 1];
                    Aeven[i] = A[i] + Aeven[i -1] ;
                }
                else
                {
                    Aeven[i] = Aeven[i - 1];
                    Aodd[i] = A[i] + Aodd[i - 1];

                }
            }
            if (Aeven[n-1] - Aeven[0] == Aodd[n-1] - Aodd[0])
            {
                count++;
            }
            for(int i = 1; i< A.Length; i++)
            {
                int sumEven = Aeven[i-1] + (Aodd[n - 1] - Aodd[i]);
                int sumOdd =  Aodd[i - 1] + (Aeven[n - 1] - Aeven[i]);
                if (sumEven == sumOdd)
                    count++;
            }
            #region comments of writeLine
            //Console.WriteLine("Aeven");
            //foreach (var item in Aeven)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("Aodd");
            //foreach (var item in Aodd)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion
            return count;
        }
    }
}

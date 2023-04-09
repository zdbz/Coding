using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RabinKarp
    {
        public int solve(string A, string B)
        {
            long p = 26, m = (long)(Math.Pow(10, 9)) + 7, hashNeedle = 0, hasHayStack = 0, maxPower = (long)(Math.Pow(p, B.Length - 1));
            int count = 0, j = 1;

            if (B.Trim().Length < 1)
            {
                return 0;
            }
            if (B.Length > A.Length)
            {
                return 0;
            }


            if (A.Length == B.Length)
            {
                if (A == B)
                    return 0;
            }


            for (int i = 0; i < B.Length; i++)
            {
                hashNeedle += ((long)B[i] * ((long)(Math.Pow(p, B.Length - 1 - i)))) % m;
                //Console.WriteLine(" {0} - {1}", B[i], ((int)B[i] * ((int)(Math.Pow(p, B.Length - 1 - i)))) % m);
            }
            //Console.WriteLine("--------");
            //Console.WriteLine("sum : " + hashNeedle);
            //Console.WriteLine("--------------------------------");

            for (int i = 0; i < B.Length; i++)
            {
                hasHayStack += ((long)A[i] * ((long)(Math.Pow(p, B.Length - 1 - i)))) % m;
                //Console.WriteLine(" {0} - {1}", A[i], ((int)A[i] * ((int)(Math.Pow(p, B.Length - 1 - i)))) % m);
            }
            //Console.WriteLine("--------");
            //Console.WriteLine("sum : " + hasHayStack);
            //Console.WriteLine("--------------------------------");

            for (int i = B.Length; i < A.Length; i++)
            {
                if (hasHayStack == hashNeedle)
                {
                    count++;
                }
                //Console.WriteLine("removing {0},{1}", A[j - 1], (int)A[j - 1]);
                //Console.WriteLine("Substracting {0}", hasHayStack - ((int)A[j - 1] * maxPower));
                //Console.WriteLine("Multiplying Power {0}", (hasHayStack - ((int)A[j - 1] * maxPower)) * p);
                //Console.WriteLine("Adding - ascii of {0} {1}", A[i], (int)A[i]);
                hasHayStack = (((hasHayStack - ((int)A[j - 1] * maxPower)) * p) + ((int)A[i])) % m;
                //Console.WriteLine("sum - " + hasHayStack);
                j++;

                //hashHay *= p;
                //hashHay = (hashHay + ((int)haystack[i])) % m;
            }
            //Console.WriteLine("{0} , {1}", hashNeedle, hasHayStack);
            if (hasHayStack == hashNeedle)
            {
                count++;
            }
            return count;

        }
    }
}

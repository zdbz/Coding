using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.WebPages;

namespace LeetCode
{
  
    class Program
    {
        static void Main(string[] args)
        {

            #region hidden
            //Solution solution = new Solution();
            //PartitionArray partitionArray = new PartitionArray();
            //int[] nums = new int[] { 1,3,5,7,9};
            //int[] nums1 = new int[] {2,4,6,8};
            //var region = "Europe";
            //var name = "Belarus";
            //string url = $"https://jsonmock.hackerrank.com/api/countries?region={region}&name={name}";
            //WebRequest requestObject = WebRequest.Create(url);
            //requestObject.Method = "GET";
            //HttpWebResponse responseObject = (HttpWebResponse)requestObject.GetResponse();

            //using (Stream stream =responseObject.GetResponseStream())
            //{
            //    StreamReader streamReader = new StreamReader(stream);
            //    var obj = Json.parse(streamReader);
            //    Console.WriteLine(streamReader.ReadToEnd());
            //    streamReader.Close();
            //}


            //  Console.WriteLine(solution.PivotIndex(nums)); 
            // Console.WriteLine(partitionArray.CanThreePartsEqualSum(nums));
            //MedianTwoSortedArrays.FindMedianSortedArrays(nums, nums1);

            //LinkedList l1 = new LinkedList();
            //LinkedList l2 = new LinkedList();

            //ListNode first = new ListNode(2);
            //ListNode second = new ListNode(4);
            //ListNode third = new ListNode(3);
            //first.next = second;
            //second.next = third;
            //ListNode f2 = new ListNode(5);
            //ListNode s2 = new ListNode(6);
            //ListNode t3 = new ListNode(4);
            //f2.next = s2;
            //s2.next = t3;


            //LinkedListAddTwoNumbers linkedlist = new LinkedListAddTwoNumbers();
            //linkedlist.AddTwoNumbers(l1,l2); 
            #endregion
            SortedInsertedPosition sortedInsertedPosition = new SortedInsertedPosition();
            List<int> A = new List<int> { 1, 2,4 };
            int B = 3;
           // Console.WriteLine(sortedInsertedPosition.searchInsert(A, B));
            string b = " ";
            //RabinKarp rabinKarp = new RabinKarp();
            //rabinKarp.solve("abababababababab", "");
            //Console.WriteLine( b.Trim().Length);
            //BoringSubstring bs = new BoringSubstring();
            //Console.WriteLine(bs.solve("wwuvuw"));
            SpecialIndex special = new SpecialIndex();
            //int[] a = new int[] { 1, 2, };
            Console.WriteLine(special.WaysToMakeFair(new int[] { 2,1,6,4 }));
            ContinousSumQuery continousSumQuery = new ContinousSumQuery();
            var query = new List<List<int>>();
            
            query.Add(new List<int> { 1, 2, 10 });
            query.Add(new List<int> { 2, 3, 20 });
            query.Add(new List<int> { 2, 5, 25 });
            Console.WriteLine(continousSumQuery.solve(5,query));


            Console.Read();
        }
    }
}

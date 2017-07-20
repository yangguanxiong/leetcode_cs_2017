// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// class Solution {

//     static int lonelyinteger(int[] a) {
//         // Complete this function
//         int result = 0;
//         for(int i = 0; i < a.Length; i++){
//             result ^= a[i];
//         }
//         return result;
//     }

//     static void Main(String[] args) {
//         // int n = Convert.ToInt32(Console.ReadLine());
//         // string[] a_temp = Console.ReadLine().Split(' ');
//         // int[] a = Array.ConvertAll(a_temp,Int32.Parse);
//         int[] a = new int[]{0,9,1,2,3,4,5,4,3,2,1,0, 9, 8};
//         int result = lonelyinteger(a);
//         Console.WriteLine(result);
//     }
// }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace leetcode_cs_2017
{
    class Program
    {
        public static int FunctionA(int input)
        {
            int output = 0;

            for (int i = 0; i <  8; i++)
            {
                output *= 2;
                output += input % 2;
                input /= 2;
            }
            return output;
        }

        public static void Merge(int[] a, int[] b, int[] c, int[] merged)
        {// assume merged index is larger than three arrays
            int i = 0;
            int j = 0;
            int k = 0;

            for (int index = 0; index < a.Length + b.Length + c.Length; index++)
            {
                int minNum = Int32.MaxValue;
                int flag = 0;
                if (i < a.Length)
                {
                    minNum = a[i];
                    flag = 1;
                }

                if (j < b.Length && minNum > b[j])
                {
                    minNum = b[j];
                    flag = 2;
                }

                if (k < c.Length && minNum > c[k])
                {
                    minNum = c[k];
                    flag = 3;
                }

                merged[index] = minNum;
                if (flag == 1)
                {
                    i++;
                }
                else if (flag == 2)
                {
                    j++;
                }
                else
                    k++;
            }

        }


        public static void Main(String[] args)
        {

            // var rest = FunctionA(5);
            //  Console.WriteLine(Convert.ToString(5, 2));
            // Console.WriteLine(Convert.ToString(rest, 2));

            var list = "abcdefg";  
            Console.WriteLine(list[3]);



        }
    }
}

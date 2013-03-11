using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMergeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry1 = new int[] {0,3,7,8,9,10,13,15,17};
            int[] arry2 = new int[] {1,2,4,5,6 };

            int[] mergedArry = MergeArrays(arry1, arry2);

            for (int i = 0; i < (arry1.Length + arry2.Length -1); i++)
            {
                Console.WriteLine(mergedArry[i]);
            }
            Console.ReadLine();
        }

        private static int[] MergeArrays(int[] arry1, int[] arry2)
        {
            int length = (arry1.Length + arry2.Length)-1;
            int[] newArray = new int[length];
            int x = 0;
            int y = 0;



            for (int i = 0; i < length; i++)
            {
                var a = arry1[x];
                var b = arry2[y];
                var arry1Length = arry1.Length-1;
                var arry2Length = arry2.Length-1;
                
                //var shortList = (arry1.Length < arry2.Length) ? arry1.Length-1 : arry2.Length-1;
                //newArray[i] = GetArray(a, b, ref x, ref y, shortList);

                newArray[i] = GetArray(a, b, ref x, ref y, arry1Length, arry2Length);

                //if (a < b || (y == arry2Length))
                //{
                //    newArray[i] = a;
                //    if (x == arry1Length)
                //        continue;
                //    x++;
                //}
                //else if (a > b || (x == arry1Length))
                //{
                //    newArray[i] = b;
                //    if (y == arry2Length)
                //        continue;
                //    y++;
                //}
            }
            return newArray;
        }

        private static int GetArray(int a, int b, ref int x, ref int y, int arry1Length, int arry2Length)
        {
            if (a < b || (y == arry2Length))
            {
                int newInt = a;
                if (x == arry1Length)
                {
                }
                else
                {
                    x++;
                }
                return newInt;
            }
            return GetArray(b, a, ref y, ref x, arry1Length, arry2Length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray1 = { 1, 3, 5, 7, 9 };


            int[] intArray2 = new int[5];
            intArray2[0] = 1;
            intArray2[1] = 3;
            intArray2[2] = 5;
            intArray2[3] = 7;
            intArray2[4] = 9;

            int[] intArray3 = new int[] { 1, 3, 5, 7, 9 };


            SumAll(intArray1);
            SumAll(intArray2);
            SumAll(new int[] { 1,3,3,334333,3343});

            SumAll(1, 2, 3, 4565, 566676, 45, (int)333.4);
        }
        static int SumAll(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}

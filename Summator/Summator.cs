using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public class Summator
    {
        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }

            return sum;
        }

        public static double Average(double[] arr)
        {
            double sum = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    break;
                }
                sum += arr[i];

            }


            if (sum == 0)
            {
                return 0;
            }
            double average = Math.Round(sum / arr.Length);
            return average;
        }
    }
}
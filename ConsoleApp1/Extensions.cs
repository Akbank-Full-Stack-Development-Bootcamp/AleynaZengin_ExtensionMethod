using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Extensions
    {
        

        public static double Round(this double value, int digits)
        {
            return Math.Round(value, digits);
        }

       
        public static int [] addNumberstoArray(this int value)
        {
            int[] array = new int[value];
            for (int i = 0; i < value; i++)
            {
                Console.Write("Number {0} : ", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        public static int findMaxNumberinArray(this int[] array)
        {

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;

        }
        public static int findMinNumberinArray(this int[] array)
        {

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;

        }



    }
}

using System;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           Opening_Message();
            
        }
        public static void Opening_Message()
        {

            Console.WriteLine("\n1- Round number");
            Console.WriteLine("2- Find max and min number in array");
            Console.WriteLine("Enter the number for the programme you want to do. To exit press 0");
            int choice = int.Parse(Console.ReadLine());
            Menuhelper(choice);
        }

        public static void Menuhelper(int value)
        {
            Console.Clear();
            switch (value)
            {
                case 1:
                    roundProgramme();
                    break;
                case 2:
                    ArrayProgramme();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;

            }
            Opening_Message();

        }

        private static void ArrayProgramme()
        {
            int arraylength;
            Console.WriteLine("\nFind maximum and minimum element in an array");
            Console.WriteLine("----------------------------------------");

            Console.Write("Input the number of elements to be stored in the array :");
            arraylength = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[arraylength];

            Console.Write("Input {0} elements in the array :\n", arraylength);
            arr1 = Extensions.addNumberstoArray(arraylength);
            int max = arr1.findMaxNumberinArray();
            int min = arr1.findMinNumberinArray();

            Console.Write("Maximum element is : {0}\n", max);
            Console.Write("Minimum element is : {0}\n\n", min);
        }

        private static void roundProgramme()
        {
            Console.WriteLine("Enter the comma number you want to round(use ,)");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Number you entered : " + a);
            var result = a.Round(1);
            Console.WriteLine(a + " number is rounded to: " + result);

        }


    }
}

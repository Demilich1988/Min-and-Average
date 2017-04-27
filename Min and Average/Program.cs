using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_and_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create array from which we will find min and average values
            int[] array = new int[] { 2, 4, 5, 6, 7, 16, 50 };

            //Variable to hold minimum
            int currentMin = Int32.MaxValue;

            //Variable to hold total of array
            int total = 0;

            //Float to hold the total average
            float average;

            //Foreach to go though array to find min
            foreach(int a in array)
            {
                //if loop to see if current value is below currentMin
                if (a < currentMin)
                {
                    currentMin = a;
                }
            }

            //Print out result
            Console.WriteLine("The minimum value is "+ currentMin);

            //Foreach to go though array and find average
            foreach (int b in array)
            {
                total += b;
            }

            average = (float)total / array.Length;

            Console.WriteLine("The average is "+average);
        }
    }
}

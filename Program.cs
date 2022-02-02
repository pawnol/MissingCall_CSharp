/*
 * Missing Call
 * Pawelski
 * 2/1/2022
 * Read over the code and run the program a few times to determine
 * what the program currently does and how currently it works. Once 
 * you understand the program, add the code described on the activity
 * sheet. In addition, answer the question on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingCall
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add your code here!
        }

        /*
         * The DisplayRectangle method displays a rectangle made of
         * asterisks with the given height and width to the console.
         * height represents the height of the rectangle
         * width represents the width of the rectangle
         */
        private static void DisplayRectangle(int height, int width)
        {
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

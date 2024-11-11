/*
 * Emmelia Gardner
 * IT-230
 * Creates four integer variables and initializes them to 13, 55, 123, and 325, then finds and prints their sum and product values.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addmultiplyfourints
{
    internal class Program
    {
        // Method to find sum of four ints
        public static int getSum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        // Method to find product of four ints
        public static int getProduct(int a, int b, int c, int d)
        {
            return a * b * c * d;
        }

        public static void Main()
        {
            // Initialize variables
            int var1 = 13;
            int var2 = 55;
            int var3 = 123;
            int var4 = 325;

            // Print statements
            Console.WriteLine("The sum of 13, 55, 123, and 325 = " + getSum(var1, var2, var3, var4));
            Console.WriteLine("The product of 13, 55, 123, and 325 = " + getProduct(var1, var2, var3, var4));
        }
    }
}

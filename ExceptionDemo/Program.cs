using System;
using System.Collections.Generic;
namespace ExceptionDemo
{
    class MainClass
    {

        public static void ArrayFun()
        {
            int[] nums = new int[] { 3, 6, 6 };
            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(nums[3]);
        }


        public static void Main(string[] args)
        {

            try
            {
                ArrayFun();
            }
            catch (IndexOutOfRangeException oor)
            {
                Console.WriteLine("Oops, we went out of bounds!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops. Something went wrong. Try again later.");
            }


        }
    }
}

  

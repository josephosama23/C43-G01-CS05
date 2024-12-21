using System;
using System.Reflection.Metadata;

namespace Assignment05
{
	internal class Program
	{
        #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        static void Calculate(int num1, int num2, int num3, int num4)
        {
            int sum = num1 + num2;          
            int sub = num3 - num4;    

            Console.WriteLine($"The sum {num1} and {num2} is: {sum}");
            Console.WriteLine($"The difference {num3} and {num4} is: {sub}");
        }

        static void Main()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first number:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num4 = int.Parse(Console.ReadLine());
            Calculate(num1, num2, num3, num4);

            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int result1 = Sum(number);
            Console.WriteLine($"The sum of digits of{number} is: {result1}");


            int[] numbers = { 1, 2, 3, 4, 5, 8 };
            int minvalue = 0, maxvalue = 0;
            MinMaxArray(numbers, ref minvalue, ref maxvalue);
            Console.WriteLine($"The minimum value in the array is: {minvalue}");
            Console.WriteLine($"The maximum value in the array is: {maxvalue}");
        }
        #endregion
        #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        static int Sum(int number)
        {
            int sum = 0;
            for(int i=0; i<=number; i++)
            {
                sum += number%10;
                number /= 10;
            }
            return sum;

        }


        #endregion
        #region


        #endregion
        #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters


        static void MinMaxArray(int[] array, ref int min, ref int max)
        {
            min = array[0];
            max = array[0];
            foreach (int num in array)
            {
                if (num < min)
                {
                    min = num; 
                }
                if (num > max)
                {
                    max = num; 
                }
            }
        }


        #endregion
        #region



        #endregion
    }

}



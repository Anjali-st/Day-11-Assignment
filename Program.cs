using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppBasicCSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // --------------------------Task - 1 Print Hello World-----------------------------------


            Console.WriteLine("Hello World");
            Console.ReadKey();


            //------------------------------ Task - 2 Vriable and User Input------------------------------------------

            // Ask the user for their name
            Console.Write("Enter your name: ");

            // Use a variable to store the user's input
            string userName = Console.ReadLine();

            // Print a personalized greeting message to the console
            Console.WriteLine($"Hello, {userName}!");
            Console.ReadLine();


            //---------------------------------Task -3  Basic Arithmetic--------------------------------------------

            // Ask the user for two integers
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Addition
            int additionResult = num1 + num2;
            Console.WriteLine($"Addition: {num1} + {num2} = {additionResult}");

            // Subtraction
            int subtractionResult = num1 - num2;
            Console.WriteLine($"Subtraction: {num1} - {num2} = {subtractionResult}");

            // Multiplication
            int multiplicationResult = num1 * num2;
            Console.WriteLine($"Multiplication: {num1} * {num2} = {multiplicationResult}");

            // Division (handle division by zero)
            if (num2 != 0)
            {
                double divisionResult = (double)num1 / num2;
                Console.WriteLine($"Division: {num1} / {num2} = {divisionResult}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            // Modulus
            int modulusResult = num1 % num2;
            Console.WriteLine($"Modulus: {num1} % {num2} = {modulusResult}");
            Console.ReadLine();

            //-----------Task -4 : Control Stuctures--------------------

            // Ask the user to enter an integer
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is even or odd using if-else
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
                Console.ReadLine();


            }

            //------------------------Task -5 Loops -------------------------------
            //
            // Use a for loop to print numbers from 1 to 10

            //for (int i = 1; i <= 10; i++)
            //{
            //Console.WriteLine(i);
            //}


            // Use a while loop to print numbers from 1 to 10
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadLine();


            //---------------------Task - Arrays-------------------------

            // Declare an integer array with five elements and initialize it with values
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Calculate the sum of the elements in the array
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            // Calculate the average of the elements in the array
            double average = (double)sum / numbers.Length;

            // Display the sum and average on the console
            Console.WriteLine("Array elements: " + string.Join(", ", numbers));
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.ReadKey();


            //-------------------Task- 7 Methods-----------------

            // Prompt the user to enter an integer
            //    Console.Write("Enter a positive integer: ");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    // Call the CalculateFactorial method to compute the factorial
            //    long factorial = CalculateFactorial(num);

            //    // Display the result on the console
            //    Console.WriteLine($"Factorial of {num} is: {factorial}");
            //}

            //// Method to calculate factorial using recursion
            //static long CalculateFactorial(int n)
            //{
            //    // Base case: factorial of 0 is 1
            //    if (n == 0)
            //        return 1;
            //    else
            //        return n * CalculateFactorial(n - 1);


            //}

            //------------------------Task-8 Exception Handling------------------

            Console.Write("Enter a positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Call the CalculateFactorial method to compute the factorial
            long factorial = CalculateFactorial(num);

            // Display the result on the console
            Console.WriteLine($"Factorial of {num} is: {factorial}");
        }

        // Method to calculate factorial using recursion
        static long CalculateFactorial(int n)
        {
            // Base case: factorial of 0 is 1
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);



        }
        




    }
}

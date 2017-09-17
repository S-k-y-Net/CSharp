using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.ExercisesFrom1to20
{
    class FirstToTwenty
    {
        //Write a C# Sharp program to print Hello and your name in a separate line
        public void HelloWithMyName()
        {
            Console.WriteLine("Hello \nMy name is Max");
        }

        //Write a C# Sharp program to print the sum of two numbers.
        public void SumOfTwoNumbers()
        {
            int a, b;
            Console.WriteLine("Get me two number a and b:\n");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
        }

        //Write a C# Sharp program to print the result of dividing two numbers.
        public void DivideTwoNUmbers()
        {
            int a, b;
            Console.WriteLine("Get me two number a and b:\n");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine(a / b);
        }

        //Write a C# Sharp program to print the result of the specified operations
        /*Test data:
            -1 + 4 * 6
            ( 35+ 5 ) % 7
            14 + -4 * 6 / 11
            2 + 15 / 6 * 1 - 7 % 2
        */
        public void SpecifiedOperations()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }

        //Write a C# Sharp program to swap two numbers
        public void SwapTwoNUmber()
        {
            int a, b;
            Console.WriteLine("Get me two number a and b:\n");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            int c = a; a = b; b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        //Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user
        public void MultiplicationOfThreeNumbers()
        {
            int a, b, c;
            Console.WriteLine("Get me three number a, b and c:\n");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The result is : " + a * b * c);
        }

        // Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user
        public void ForOperationWithTwoNumber()
        {
            int a, b;
            Console.WriteLine("Get me two number a and b:\n");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Adding: " + (a + b) + "\nSubtracting: " + (a - b) + "\nMultiplying: " + (a * b) + "\nDividing: " + (a / b));
        }

        //Write a C# Sharp program that takes a number as input and print its multiplication table
        public void MultiplicationTable()
        {
            int a;
            Console.WriteLine("Get me a number:\n");
            a = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(a + " * " + i + " = " + (a * i));
            }
        }
    }
}

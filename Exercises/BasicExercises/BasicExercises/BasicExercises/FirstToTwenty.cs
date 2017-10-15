using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.ExercisesFrom1to20
{
    class FirstToTwenty
    {
        //1. Write a C# Sharp program to print Hello and your name in a separate line
        public void HelloWithMyName()
        {
            Console.WriteLine("Hello \nMy name is Max");
        }

        //2. Write a C# Sharp program to print the sum of two numbers.
        public void SumOfTwoNumbers()
        {
            int a, b;
            Console.WriteLine("Get me two number a and b:\n");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
        }

        //3. Write a C# Sharp program to print the result of dividing two numbers.
        public void DivideTwoNUmbers()
        {
            int a, b;
            Console.WriteLine("Get me two number a and b:\n");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine(a / b);
        }

        //4. Write a C# Sharp program to print the result of the specified operations
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

        //5. Write a C# Sharp program to swap two numbers
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

        //6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user
        public void MultiplicationOfThreeNumbers()
        {
            int a, b, c;
            Console.WriteLine("Get me three number a, b and c:\n");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The result is : " + a * b * c);
        }

        //7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user
        public void ForOperationWithTwoNumber()
        {
            int a, b;
            Console.WriteLine("Get me two number a and b:\n");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Adding: " + (a + b) + "\nSubtracting: " + (a - b) + "\nMultiplying: " + (a * b) + "\nDividing: " + (a / b));
        }

        //8. Write a C# Sharp program that takes a number as input and print its multiplication table
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

        //9. Write a C# Sharp program that takes four numbers as input to calculate and print the average
        public void AverageOfFourNumber()
        {
            int a, b, c, d;
                Console.WriteLine("Get me a 4 number:\n");
                a = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());
                c = Int32.Parse(Console.ReadLine());
                d = Int32.Parse(Console.ReadLine());
            string average = String.Format("{0:0.00}", (a + b + c + d) / 4f);

            Console.WriteLine("This is average: " + average);
        }

        //10 .Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
        public void SimpleMathEquation()
        {
            int x, y, z;
            Console.WriteLine("Enter x, y, z: \n");
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            z = Int32.Parse(Console.ReadLine());
            Console.Write("(x + y) * z = " + (x + y) * z + "\nx.y + y.z = " + (x*y + y*z) + "\n");
        }

        //11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20"
        public void RudeMethod()
        {
            int age;
            Console.WriteLine("Enter your age:");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You look older than {0}", age);
        }

        //12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}
        public void PrintNumber()
        {
            int number;
            Console.WriteLine("Enter the number:");
            number = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", number);
                Console.WriteLine("{0}{0}{0}{0}", number);
            }
        }

        //13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit
        public void RectangleByNUmber()
        {
            int number;
            Console.WriteLine("Enter the number:");
            number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", number);
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("{0} {0}", number);
            }
            Console.WriteLine("{0}{0}{0}", number);
        }

        //14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit
        public void ConvertCelsiusToKelvinAndFahrenheit()
        {
            Console.WriteLine("Enter celsius: ");
            try
            {
                int celsius = Int32.Parse(Console.ReadLine());
                double fahranheit = 1.8 * celsius + 32;
                double kelvin = 273.15 + celsius;
                Console.WriteLine(celsius + " Celsius = " + fahranheit + " Fahrenheit and = " + kelvin + " Kelvin");
            }
            catch (Exception error) {
                Console.WriteLine(error);
            }
        }

        //15.Write a C# program remove specified a character from a non-empty string using index of a character. 
        /*Test Data:
        w3resource
        Sample Output:
        wresource
        w3resourc
        3resource*/
        public void RemoveCharacterByIndex()
        {
            Console.WriteLine("Enter string: ");
            string userString = Console.ReadLine();

            try
            {
                Console.WriteLine("Enter index of character which should be remove");
                int index = Int32.Parse(Console.ReadLine());
                userString = userString.Remove(index - 1, 1);
                Console.WriteLine(userString);
            }
            catch (Exception error)
            {
                Console.Write(error);
            }

            //foreach (char ch in arr)
            //{
            //    Console.Write(ch + "\n");
            //}
        }
        //16. Write a C# program to create a new string from a given string where the first and last characters will change their positions.
        //Test Data:
        //w3resource
        //Python
        //Sample Output:
        //e3resourcw
        //nythoP
        
        public void ChangeFirstAndLastChars()
        {
            Console.WriteLine("Enter string and I change first and last character positions");
            string userInput = Console.ReadLine();

            try
            {
                //not my solutioin
                userInput = userInput.Length > 1 ? userInput.Substring(userInput.Length - 1) + userInput.Substring(1, userInput.Length - 2) + userInput.Substring(0, 1) : userInput;
                Console.WriteLine(userInput);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        //17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back. 
        //Sample Output:
        //Input a string : The quick brown fox jumps over the lazy dog.
        //TThe quick brown fox jumps over the lazy dog.T
        public void AddFirstCharToFrontAndBack()
        {
            Console.WriteLine("Enter string: ");
            string userInput = Console.ReadLine();
            userInput = userInput.Length > 1 ? userInput.Insert(0, userInput.Substring(0, 1)) + userInput.Substring(0, 1) : userInput;
            Console.WriteLine(userInput);
        }

        //Write a C# program to check two given integers and return true if one is negative and one is positive. Go to the editor
        //Sample Output:
        //Input first integer:
        //-5 
        //Input second integer: 
        //25 
        //Check if one is negative and one is positive: 
        //True
        public Boolean CheckIfPositiveAndNagative()
        {
            Console.WriteLine("Input first integer");
            int first = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer");
            int second = Int32.Parse(Console.ReadLine());

            if ((first > 0 & second < 0) || (first < 0 & second > 0)) {
                return true;
            }
            else
            {
                return false;
            }
        }

        //19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum
        public double SumAndTripleSumIfEqual(double first, double second)
        {
            double sum = first + second;
            if (first.Equals(second))
            {
                return sum * 3;
            }
            return sum;
            //Solution from outside
            //return a == b ? (a + b) * 3 : a + b;
        }

        //20. Write a C# program to get the absolute value of the difference between two given numbers. 
        //Return double the absolute value of the difference if the first number is greater than second number
        public double AbsoluteDifferenceBetweenTwo(double first, double second)
        {
             
            if (first > second)
            {
                return Math.Abs(Math.Abs(first) - Math.Abs(second)) * 2;
            }
            return Math.Abs(Math.Abs(first) - Math.Abs(second)); ;
            //return first > second ? Math.Abs(Math.Abs(first) - Math.Abs(second)) : Math.Abs(Math.Abs(first) - Math.Abs(second)) * 2;
        }

        //21.Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20
        public Boolean IfEqualTwenty(int first, int second)
        {
            return first.Equals(20) || first + second == 20 || second.Equals(20) ? true : false;
        }

        //22. Write a C# program to check if an given integer is within 20 of 100 or 200
        public Boolean WithinTwentyOrHudnred()
        {
            Console.WriteLine("Input integer ");
            try
            {
                int input = Int32.Parse(Console.ReadLine());
                return Math.Abs(input - 100) <= 10 || Math.Abs(input - 200) <= 10 ? true : false;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        //23.Write a C# program to convert a given string into lowercase
        public string ConvertToLowercase(string str)
        {
            return str.ToLower();
        }

        //24. Write a C# program to find the longest word in a string. 
        //Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
        //Sample Output:
        //following
        public string FindLongestWord(string str)
        {
            int count = 0;
            string maxCount = "";
            List<string> list = str.Split().ToList();
            foreach (string word in list)
            {
                if (word.Length > count)
                {
                    maxCount = word;
                    count = word.Length;
                }
            }
            return maxCount;
        }
    }
}

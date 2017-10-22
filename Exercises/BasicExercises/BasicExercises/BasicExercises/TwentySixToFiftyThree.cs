using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.BasicExercises
{
    class TwentySixToFiftyThree
    {
        //26. Write a C# program to compute the sum of the first 500 prime numbers.
        public void SumPrimeNumber()
        {
            int div = 0;
            int sum = 0;
            int numberOfPrimes = 0;
            for (int i = 1; true; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        div += 1;
                    }
                }
                if (div <= 2)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                    numberOfPrimes += 1;
                }
                div = 0;
                if (numberOfPrimes == 501)
                {
                    Console.WriteLine(numberOfPrimes);
                    break;
                }
                
            }
            Console.WriteLine(sum);
        }

        //27. Write a C# program and compute the sum of the digits of an integer
        public void SumOfDigits()
        {
            Console.WriteLine("Enter integer number");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (input != 0)
            {
                sum += input % 10;
                input /= 10;
            }
            Console.WriteLine(sum);

        }

        //28. Write a C# program to reverse the words of a sentence.
        public void Reverce()
        {
            string line = "Display";
            Console.WriteLine("\nOriginal String: " + line);
            string result = "";
            List<string> wordsList = new List<string>();
            string[] words = line.Split(new[] {" "}, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);
            foreach (String s in wordsList)
            {

                Console.WriteLine("\nReverse String: " + s);
            }
        }
    }
}

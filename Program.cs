using System;
using System.Collections.Generic;

namespace CsharpExercisesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Nested loops - but I solved the problem with recursion.
             * In this exercise, I'll try to print out all possible number combinations.
             */
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> result = new List<int>();
            PrintEveryCombination(numbers, result);
            Console.WriteLine();

            /*
             * Multi-dimensional arrays
             * I'll implement a foreach loop that will check every value we have in the array.
             */
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            foreach (var item in array2D)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            /*
             * Reference type equality
             * I'll implement a function that compares two int arrays.
             */
            int[] firstArr = { 1, 2, 3 };
            int[] secondArr = { 1, 4, 3 };
            Console.WriteLine(AreArraysEqual(firstArr, secondArr));

            /*
             * Output Parameters
             * I'll implement a function that returns void with two int input parameters.
             * The function will have four output parameters that should return the sum, difference,
             * product and quotient of the two inputs.
             */
            int x = 4;
            int y = 6;
            int sum, difference, product, quotient;
            CalculateMathOperations(x, y, out sum, out difference, out product, out quotient);

            Console.WriteLine();
            /*
             * Reference parameters
             * I'll implement a function that can take a string and a reference to an int as arguments. This function
             * will return the character at the index specified by the given int.
             */
            int index = 3;
            string exampleString = "Hello, world!";
            Console.WriteLine(FindCharacter(exampleString, ref index));

        }

        /// <summary>
        /// This function prints every possible combination of numbers given in the arguments.
        /// </summary>
        /// <param name="numbers">The number list which you want to print out all the combinations of.</param>
        /// <param name="result">This argument is used for saving results while doing recursive calls.</param>
        /// <returns>This function returns 1 as an int32. But it does not mean anything.</returns>
        static int PrintEveryCombination(List<int> numbers, List<int> result)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> newNumbers = new List<int>(numbers);
                List<int> newResult = new List<int>(result);

                newResult.Add(numbers[i]);
                if (newResult.Count == 5)
                {
                    newResult.ForEach(Console.Write);
                    Console.WriteLine();
                }
                newNumbers.RemoveAt(i);

                PrintEveryCombination(newNumbers, newResult);
            }

            return 1;
        }

        static bool AreArraysEqual(int[] firstArr, int[] secondArr)
        {
            if (firstArr.Length != secondArr.Length)
                return false;
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                    return false;
            }
            return true;
        }

        static void CalculateMathOperations(int x, int y, out int sum, out int difference, out int product, out int quotient)
        {
            sum = x + y;
            difference = x - y;
            product = x * y;
            quotient = x / y;
        }

        static char FindCharacter(string str, ref int index)
        {
            if (str.Length < index - 1)
                index = str.Length - 1;
            else if (index < 0)
                index = 0;
            return str[index];
        }
    }
}

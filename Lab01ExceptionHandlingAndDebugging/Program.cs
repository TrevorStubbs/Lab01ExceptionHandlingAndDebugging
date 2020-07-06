using System;

namespace Lab01ExceptionHandlingAndDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception caught: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Application Complete.");
            }
        }

        static void StartSequence()
        {

            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!");

                Console.WriteLine("Enter a number greater than zero.");
                int numberFromUser = Convert.ToInt32(Console.ReadLine());

                int[] initalArray = new int[numberFromUser];

                Populate(initalArray);
                int outputFromGetSum = GetSum(initalArray);
                int outputFromGetProduct = GetProduct(initalArray, outputFromGetSum);
                decimal outputFromGetQuotient = GetQuotient(outputFromGetProduct);

                Console.WriteLine($"Your array is size: {numberFromUser}");

                Console.Write("The numbers in the array are ");
                for (int i = 0; i < initalArray.Length; i++)
                {
                    if (i == initalArray.Length)
                        Console.Write($"{initalArray[i]}");
                    else
                        Console.Write($"{initalArray[i]}, ");
                }

                Console.WriteLine();
                Console.WriteLine($"The sum of the array is {outputFromGetSum}");
                Console.WriteLine($"{outputFromGetSum} * {outputFromGetProduct/outputFromGetSum} = {outputFromGetProduct}");
                Console.WriteLine($"{outputFromGetProduct} / {outputFromGetProduct / outputFromGetQuotient} = {outputFromGetQuotient}");              

            }
            catch (FormatException)
            {
                Console.WriteLine($"You did not enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Your number was not greater than zero");
            }
            catch (Exception)
            {
                throw;
            }
        }

        static int[] Populate(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine($"Please enter a number: {i + 1}/{inputArray.Length}");
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return inputArray;
        }

        static int GetSum(int[] inputArray)
        {
            int sum = 0;

            foreach (int number in inputArray)
                sum += number;

            if (sum < 20)
                throw (new Exception($"Value of {sum} is too low."));

            return sum;
        }

        static int GetProduct(int[] inputArray, int inputSum)
        {
            int product;

            try
            {
            Console.WriteLine($"Please select a random number between 1 and {inputArray.Length}");
            int userChosenNumber = inputArray[Convert.ToInt32(Console.ReadLine())];
            product = userChosenNumber * inputSum;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Error message: {e.Message}");
                throw;
            }

            return product;
        }

        static decimal GetQuotient(int inputNumber)
        {
            decimal convertInputToDec = Convert.ToDecimal(inputNumber);

            Console.WriteLine($"Please enter a number to divide your product {inputNumber} by");
            decimal userInputedNumber = Convert.ToDecimal(Console.ReadLine());

            decimal outputNumber;

            try
            {
                outputNumber = Decimal.Divide(convertInputToDec, userInputedNumber);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Tried to divide by Zero: {e.Message}");
                return 0;
            }

            return outputNumber;
        }
    }
}

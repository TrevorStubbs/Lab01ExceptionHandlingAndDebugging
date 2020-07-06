using System;

namespace Lab01ExceptionHandlingAndDebugging
{
    class Program
    {
        // Insertion into the whole application
        static void Main(string[] args)
        {
            try
            {
                // Run the Start Sequence
                StartSequence();
            }
            catch (Exception e)
            {
                // Catch and display the error
                Console.WriteLine($"Exception caught: {e.Message}");
            }
            finally
            {
                // Tell the user that the app is completed
                Console.WriteLine("Application Complete.");
            }
        }

        static void StartSequence()
        {

            try
            {
                // Intro Messages
                Console.WriteLine("Welcome to my game! Let's do some math!");
                Console.WriteLine("Enter a number greater than zero.");

                // Get a number from the user to define the size of the array
                int numberFromUser = Convert.ToInt32(Console.ReadLine());

                // initialize an array based off the user's input
                int[] initalArray = new int[numberFromUser];

                // Run Populate method to fill the array
                Populate(initalArray);

                // run the app's methods and capture each output into variables
                int outputFromGetSum = GetSum(initalArray);
                int outputFromGetProduct = GetProduct(initalArray, outputFromGetSum);
                decimal outputFromGetQuotient = GetQuotient(outputFromGetProduct);

                // Print the size of the array
                Console.WriteLine($"Your array is size: {numberFromUser}");

                // Loop through each item and print them to the console
                Console.Write("The numbers in the array are ");
                for (int i = 0; i < initalArray.Length; i++)
                {
                    if (i == initalArray.Length)
                        Console.Write($"{initalArray[i]}");
                    else
                        Console.Write($"{initalArray[i]}, ");
                }

                Console.WriteLine();

                // Print the outcomes of the methods
                Console.WriteLine($"The sum of the array is {outputFromGetSum}");
                Console.WriteLine($"{outputFromGetSum} * {outputFromGetProduct/outputFromGetSum} = {outputFromGetProduct}");
                Console.WriteLine($"{outputFromGetProduct} / {outputFromGetProduct / outputFromGetQuotient} = {outputFromGetQuotient}");              

            }
            catch (FormatException)
            {
                // Tell the user that they didn't enter a number
                Console.WriteLine($"You did not enter a number");
            }
            catch (OverflowException)
            {
                // Tell the user that the number was not a zero.
                Console.WriteLine($"Your number was not greater than zero");
            }
            catch (Exception)
            {
                // Whatever exception enters here let the main deal with it.
                throw;
            }
        }

        // This method populates the array with user defined values
        static int[] Populate(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine($"Please enter a number: {i + 1}/{inputArray.Length}");
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return inputArray;
        }

        // This method will sum all the values in the array together and output it into a single int
        static int GetSum(int[] inputArray)
        {
            int sum = 0;

            foreach (int number in inputArray)
                sum += number;

            // if the sum is less than zero send a new exception through the chain.
            if (sum < 20)
                throw (new Exception($"Value of {sum} is too low."));

            return sum;
        }

        // Have the user select a random index from the array and have it be multiplied by the sum of the previous method.
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

        // Divide a user inputed number by the product produced by the previous method.
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

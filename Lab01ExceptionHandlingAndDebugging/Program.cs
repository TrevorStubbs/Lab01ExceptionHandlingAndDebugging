using System;

namespace Lab01ExceptionHandlingAndDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

        //StartSequence
        //  static void (no params)
        static void StartSequence()
        {

            try
            {
                // User to Enter a number greater than zero
                Console.WriteLine("Welcome to my game! Let's do some math!");

                Console.WriteLine("Enter a number greater than zero.");
                int numberFromUser = Convert.ToInt32(Console.ReadLine());
                // maybe put a while loop in to make sure numbeFromUser != 0


                int[] initalArray = new int[numberFromUser];

                //Testing DELETE LATER
                Console.WriteLine($"You entered {numberFromUser}");

                Populate(initalArray);

                int outputFromGetSum = GetSum(initalArray);
                int outputFromGetProduct = GetProduct(initalArray, outputFromGetSum);

                Console.WriteLine($"this is the sum: {outputFromGetProduct}");
                // int product = GetProduct(int[], sums)
                // int quotient = getQuotient(product)

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

        //Populate
        // static int[] (int [])
        static int[] Populate(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine($"Please enter a number: {i + 1}/{inputArray.Length}");
                inputArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            return inputArray;
        }

        //GetSum
        // static int (int[])
        static int GetSum(int[] inputArray)
        {
            int sum = 0;

            foreach (int number in inputArray)
                sum += number;

            if (sum < 20)
                throw (new Exception($"Value of {sum} is too low."));

            return sum;
        }

        //GetProduct
        // static int (int[])
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

            return product; // Change later
        }

        //Get Quotient
        // static decimal (int [from GetProduct)

    }
}

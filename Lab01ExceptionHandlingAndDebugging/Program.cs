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
            // User to Enter a number greater than zero
            Console.WriteLine("Welcome to my game! Let's do some math!");
            Console.WriteLine("Enter a number greater than zero.");
            int numberFromUser = Convert.ToInt32(Console.ReadLine());

            int[] initalArray = new int[numberFromUser];
            try
            {
                // Populate();
                // int[] sums = GetSum(int[])
                // int product = GetProduct(int[], sums)
                // int quotient = getQuotient(product)

            }
            catch (FormatException e)
            {
                Console.WriteLine($"{numberFromUser} is not a number");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"{numberFromUser} is not greater than zero");
            }
            catch (Exception) // TODO find specific error
            {
                throw;
            }
        }

        //Populate
        // static int[] (int [])

        //GetSum
        // static int (int[])

        //GetProduct
        // static int (int[])

        //Get Quotient
        // static decimal (int [from GetProduct)

    }
}

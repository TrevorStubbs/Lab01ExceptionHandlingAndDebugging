﻿using System;

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

                // int[] sums = GetSum(int[])
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

        //GetProduct
        // static int (int[])

        //Get Quotient
        // static decimal (int [from GetProduct)

    }
}

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
                //StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Application Complete.");
            }
        }

        //StartSequence
            //  static void (no params)
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

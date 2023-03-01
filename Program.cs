using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
       


        static void Main(string[] arg)

        {

 

 
    var numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        var Evens = new List<int>();
        var Odds = new List<int>();
    //The foreach loops goes through the array and checks the if condition to see which list to add the number to
    foreach ( var num in numbers)
    {
            if ( num % 2 == 0)
            {
                Evens.Add(num);
            }
            else if ( num % 2 != 0)
            {
                Odds.Add(num);
            }
    }
    foreach ( var e in Evens)
    {
        Console.WriteLine(e);
    }
    foreach ( var o in Odds)
    {
        Console.WriteLine(o);
    }













           
            //TODO:


            //DONE Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        
    }
}
}

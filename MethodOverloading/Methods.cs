using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
      //Create a method named Add, that accepts two integers and returns the sum of those two integers
      public static int Add(int x, int y)
        { 
            return x + y;
        }

        //Now create an overload of the Add method to account for being able to add two decimals together
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        //Now create another overload of the Add method that returns a string and accepts
        //3 parameters: 2 integers and 1 boolean
        //If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers
        //plus the word “dollars” at the end of the string.
        //You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
        public static string Add(int x, int y, bool withDollars)
        {
            if (withDollars && (x + y) != 1)
            {
                return $"{x + y} dollars";
            }
            else if (withDollars && (x + y) == 1)
            {
                return $"{x + y} dollar";
            }
            else
            {
                return $"{x + y}";
            }
        }
    }
}

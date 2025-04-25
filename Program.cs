using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingtest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("reverse number " +
                "of {0} is {1}", 123, Reverse.intReverse(123));


            Console.WriteLine("reverse string of {0} is {1}", "Apple", Reverse.strReverse("Apple"));


            Console.WriteLine("string is palindrome {0} is {1}", "dad", Reverse.strPalindrome("dad"));

            Console.WriteLine("string is palindrome {0} is {1}", "Apple", Reverse.strPalindrome("Apple"));

            Reverse.countEachCharacter("Apple");

            Console.WriteLine("string remove duplicate of {0} is {1}", "Apple", Reverse.removeString("Apple"));

        }
    }
}

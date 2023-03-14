using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
      static void Main(string[] args)
        {
            string reversedWords = StringHelper.ReverseWords("Ala ma kota");

            bool isPalindrome = StringHelper.IsPalindrome("ala");

            Console.WriteLine("Result. The reversed words: " + reversedWords);

            Console.WriteLine("Result. Is palindrome word: " + isPalindrome);

        }
    }
}

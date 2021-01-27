using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public static string FizzBuzz1(int n)
        {
            string result = "";
            if (n % 3 == 0)
                result += "Fizz";
            if (n % 5 == 0)
                result += "Buzz";
            if (result.Length == 0)
                return n.ToString();
            return result;
        }
        public static string FizzBuzz2 (int n)
        {
            if (n % 15 == 0)
                return "FizzBuzz";
            if (n % 5 == 0)
                return "Buzz";
            if (n % 3 == 0)
                return "Fizz";
            return n.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

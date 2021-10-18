using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello World!";
            string s2 = "321";
            string s3 = "!";
            string s4 = "";

            Console.WriteLine($"{s1} -> {ReverseSymbols(s1)}");
            Console.WriteLine($"{s2} -> {ReverseSymbols(s2)}");
            Console.WriteLine($"{s3} -> {ReverseSymbols(s3)}");
            Console.WriteLine($"{s4} -> {ReverseSymbols(s4)}");

        }

        public static string ReverseSymbols(string s)
        {
            var arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}

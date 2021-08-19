using System;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (str.Length > 100)
            {
                throw new Exception("String is longer than 100 characters");
            }
            Console.WriteLine("Reversed string:");
            Console.WriteLine(ReverseString(str));
        }
        public static string ReverseString(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return str;
            }
            return ReverseString(str.Substring(1)) + str[0];
        }
    }
}

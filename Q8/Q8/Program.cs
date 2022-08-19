using System;
namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            Console.WriteLine("8.Prime numbers with anagrams and palindrome");
            Console.WriteLine("Enter the Question No."); ;
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                /// For Question No. 8
                case 8:
                    Console.WriteLine("Enter First number:");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number :");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int res1 = PrimeNumExtend.FindPrime(num1);
                    int res2 = PrimeNumExtend.FindPrime(num2);

                    bool anagramRes = PrimeNumExtend.FindAnagram(Convert.ToString(num1), Convert.ToString(num2));

                    bool palindormres = PrimeNumExtend.IsPalindrome(num1);

                    if (anagramRes)
                    {
                        Console.WriteLine("both values are anagrams");

                    }
                    else
                    {
                        Console.WriteLine("both the values are not anagrams");
                    }
                    if (palindormres)
                    {
                        Console.WriteLine("Number is palindrome");
                    }
                    else
                    {
                        Console.WriteLine("Number is not a palindrome");
                    }
                    break;

                default:
                    Console.WriteLine("Enter the correct Question No.!");
                    break;
            }
            Console.WriteLine("\nThank You!");
            Console.ReadLine();
        }
    }

}
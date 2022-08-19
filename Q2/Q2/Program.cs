using System;
using System.Collections.Generic;
using System.IO;
namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            Console.WriteLine("Q2.Binary Search the word from wordlist");
            Console.WriteLine("Enter the Question No.");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                ///For Question 2
                case 2:
                    string txtpath = File.ReadAllText(@"C:\Users\Amit Pegu\Desktop\Algorithm\Q2\Algorithm.txt");
                    List<string> words = new List<string>(txtpath.Split());
                    words.Sort();
                    BinarySearch.BinarySearchWord(words);
                    break;

                default:
                    Console.WriteLine("Enter the valid option!");
                    break;
            }
            Console.WriteLine("\nThank You!");
            Console.ReadLine();
        }
    }

}
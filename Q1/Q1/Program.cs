﻿using System;
namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            Console.WriteLine("1.Permutation Using Recursion");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                ///For Question-1
                case 1:
                    Console.WriteLine("Enter String to find Permutation ");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    Permutations.Permutate(str, 0, n - 1);
                    break;

                default:
                    Console.WriteLine("Enter the valid option!");
                    break;
            }
            Console.WriteLine("\nThankyou!");
            Console.ReadLine();
        }
    }

}
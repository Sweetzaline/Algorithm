using System;
namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            Console.WriteLine("6.Anagram Detection Example");
            Console.WriteLine("Enter the Question No."); ;
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
               ///For UseCase6
                case 6:
                    AnagramDetection.FindAnagram();
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
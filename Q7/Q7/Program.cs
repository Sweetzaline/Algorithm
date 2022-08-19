using System;
namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Algorithm Programs!");
            Console.WriteLine("7.Prime number in range");
            Console.WriteLine("Enter the Question No."); ; 
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                 ///For UseCase7
                case 7:
                    Console.WriteLine("The prime numbers in the range of 1-1000 are : ");
                    PrimeNumInRange primeNum = new PrimeNumInRange();
                    primeNum.FindPrime();
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
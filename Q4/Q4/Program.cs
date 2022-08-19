using System;
namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            Console.WriteLine("4.Bubble Sort");
            Console.WriteLine("Enter the Question No.");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                ///For Question No.4
                case 4:
                    int[] arr1 = { 10, 2, 14, 3, 1, 5, 9 };
                    BubbleSort.BubbleSortInArray(arr1);
                    BubbleSort.PrintArray(arr1);
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
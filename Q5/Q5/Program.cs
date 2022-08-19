using System;
namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            Console.WriteLine("5.Merge sort");
            Console.WriteLine("Enter the Question No.");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                
                ///For Question No. 5
                case 5:
                    int[] arr2 = { 32, 12, 9, 65, 24, 5 };
                    MergeSort.Sort(arr2, 0, arr2.Length - 1);
                    MergeSort.PrintArray(arr2);
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
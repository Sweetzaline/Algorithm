using System;
namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            Console.WriteLine("3.Insertion Sort");
            Console.WriteLine("Enter the Question No.");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
              ///For UseCase3
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
                    insertionSort.Sort(arr);
                    insertionSort.PrintArray(arr);
                    break;

                default:
                    Console.WriteLine("Wrong Question No.!");
                    break;
            }
            Console.WriteLine("\nThank You!");
            Console.ReadLine();
        }
    }

}
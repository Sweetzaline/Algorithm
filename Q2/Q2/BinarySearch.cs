using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2

{
    class BinarySearch
    {
        public static void BinarySearchWord(List<string> wordList)
        {
            ///Initialize Local Variables
            int mid, start = 0;
            int end = wordList.Count - 1;
            bool isFound = false;
            Console.WriteLine("Enter the word to be searched in the text file.");
            string key = Console.ReadLine();

            while (start <= end)
            {
                mid = (start + end) / 2;
                int result = key.CompareTo(wordList[mid]);
                if (result == 0)
                {
                    Console.WriteLine("The word is Present in the text file.");
                    isFound = true;
                    break;
                }
                else if (result > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("The word does not exist in the text file!");
            }

        }
    }
}
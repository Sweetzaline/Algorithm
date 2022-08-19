using System;
namespace Q1
{
    class Permutations
    {
        public static void Permutate(string str, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = (Swap(str, start, i));
                    Permutate(str, start + 1, end);
                    str = Swap(str, start, i);
                }
            }
        }
        public static string Swap(string word, int start, int end)
        {
            char temp;
            char[] charArray = word.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            string s = new string(charArray);
            return s;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
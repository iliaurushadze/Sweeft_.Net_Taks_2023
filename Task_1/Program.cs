using static System.Net.Mime.MediaTypeNames;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the word - ");
            string text = Console.ReadLine();
            Console.WriteLine(IsPalindrome(text));
        }

        public static bool IsPalindrome(string text)
        {
            int start = 0;
            int last = text.Length - 1;
            while (start <= last)
            {
                char currFirst = text[start];
                char currLast = text[last];
                if (!Char.IsLetter(currFirst) && !Char.IsDigit(currFirst))
                {
                    start++;
                }
                else if (!Char.IsLetter(currLast) && !Char.IsDigit(currLast))
                {
                    last--;
                }
                else
                {
                    if (Char.ToLower(currFirst) != Char.ToLower(currLast))
                    {
                        return false;
                    }
                    start++;
                    last--;
                }
            }
            return true;
        }
    }
}
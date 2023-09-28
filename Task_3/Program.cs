namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating the test array
            int[] array = new int[] { -12, -5, -11, -2, 0, 1, 5, 3, 4, 2, 10, 12, 25 };
            Console.WriteLine("Min integer more than 0 is - " + NotContains(array));
        }

        static int NotContains(int[] array)
        {
            HashSet<int> positiveNums = new HashSet<int>(array.Where(x => x > 0));

            int i = 1;
            while (true)
            {
                if (!positiveNums.Contains(i))
                {
                    return i;
                }
                i++;
            }
        }
    }
}
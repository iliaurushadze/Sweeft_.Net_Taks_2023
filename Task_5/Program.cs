namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of stairs - ");
            int stairCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of variants - " + CountVariants(stairCount));
        }

        static int CountVariants(int stairCount)
        {
            int[] dp = new int[stairCount + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= stairCount; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];    
            }

            return dp[stairCount];
        }
    }
}
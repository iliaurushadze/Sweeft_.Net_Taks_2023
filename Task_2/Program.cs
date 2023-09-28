namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter coin amount - ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Min amount of coins is - " + MinSplit(amount));
        }

        static int MinSplit(int amount)
        {
            int[] coins = new int[] { 1, 5, 10, 20, 50};

            int coinCount = 0;
            int index = coins.Length - 1;

            while (amount > 0 && index >= 0)
            {
                int coinValue = coins[index];
                int coinsUsed = amount / coinValue; 
                coinCount += coinsUsed; 
                amount -= coinsUsed * coinValue; 
                index--; 
            }

            return coinCount;
        }
    }
}
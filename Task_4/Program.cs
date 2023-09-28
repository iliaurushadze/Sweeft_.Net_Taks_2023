namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the sequence - ");
            string sequence = Console.ReadLine();
            Console.WriteLine(IsProperly(sequence));
        }

        static bool IsProperly(string sequence)
        {
            Stack<Char> stack = new Stack<Char>();
            foreach (var c in sequence)
            {
                if (c == '(')
                    stack.Push(')');
                else if (stack.Count == 0 || stack.Pop() != c)
                    return false;
            }
            return (stack.Count == 0);
        }
    }
}
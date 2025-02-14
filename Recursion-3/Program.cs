namespace Recursion_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            Console.WriteLine($"The reversed number is {Reverse(int.Parse(Console.ReadLine()), 0)}");
        }
        static int Reverse(int n, int reversed=0)
        {
            if (n == 0)
            {
                return reversed;
            }
            return Reverse(n / 10, reversed * 10 + n % 10);
        }
    }
}

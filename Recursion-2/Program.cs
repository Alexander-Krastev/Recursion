namespace Recursion_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            Console.WriteLine($"{PowerOf2(int.Parse(Console.ReadLine()))}");
        }
        static string PowerOf2(int n)
        {
            if (n == 2)
            {
                return "The number is a power of 2";
            }
            else if (n % 2 == 0)
            {
                return PowerOf2(n / 2);
                
            }
            else
            {
                return "The number is not a power of 2";
            }
        }
    }
}

namespace Recursion_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            Console.WriteLine($"THe sum of it's digits is {Sum(int.Parse(Console.ReadLine()))}");
        }
        static int Sum(int n)
        {
            int sum = 0;
            if (n == 0)
            {
                return 0;
            }
            else
            {
                    sum = n % 10 + Sum(n/10);
                    return sum;
            }
            
        }
    }
}

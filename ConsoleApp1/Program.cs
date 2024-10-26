namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;

            Console.WriteLine("Enter data");

            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());

            c = Convert.ToInt32(Console.ReadLine());

            int d = a + b + c;

            a *= b;

            Console.WriteLine("Result = {0}", a * c);
        }
    }
}

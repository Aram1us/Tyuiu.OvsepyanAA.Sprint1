namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            int j = i++;

            int k = ++j;

            Console.Write("i=" + i + "\\");

            Console.Write("j=" + j);

            Console.Write("k=" + k);
        }
    }
}

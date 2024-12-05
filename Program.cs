namespace Assignment_5._2._2
{
    internal class Program
    {
        public static void PrintNaturalNumbers(int n)
        {
            if (n <= 0)
            {
                return;
            }

            PrintNaturalNumbers(n - 1);

            Console.Write(n + " ");
        }
        static void Main(string[] args)
        {
            Console.Write("How many numbers to print: ");
            int n = int.Parse(Console.ReadLine());

            PrintNaturalNumbers(n);

            Console.WriteLine();
        }
    }
}

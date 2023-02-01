namespace Television
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television();

            television.startTv();

            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
namespace Assignment1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrepareConsolesLook();

            Pet petObj = new Pet();
            petObj.Start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            TicketSeller tSeller = new TicketSeller();
            tSeller.Start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            Album album = new Album();
            album.Start();

            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }

        static void PrepareConsolesLook()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "KIDS' FAIR";
        }
    }
}
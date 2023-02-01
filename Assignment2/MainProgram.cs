namespace Assignment2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "Strings, selection and iteration in C#";
            FunFeatures fun = new FunFeatures();
            fun.Start();

            ContinueToNextPart();
        }

        private static void ContinueToNextPart()
        {
            Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
            Console.ReadLine();
            Console.Clear();
            Console.Title = "MathWork Section";
            MathWork mw = new MathWork();
            mw.Start();
        }
    }
}
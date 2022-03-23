class program
{
    static void Main(string[] args)
    {
        string userName;
        char userSymbol;

        Console.WriteLine("Введите имя:");
        userName = Console.ReadLine();
        Console.WriteLine("Введите символ:");
        userSymbol = Convert.ToChar(Console.ReadLine());

        int numberSymbolsUpperLineFrame = userName.Length;
        int numberSymbolsLowerLineFrame = userName.Length;

        for(int i = 0; i < numberSymbolsUpperLineFrame; i++)
        {
            Console.Write(userSymbol);
        }
        Console.WriteLine($"\n{userSymbol}{userName}{userSymbol}");
        for(int i = 0; i < numberSymbolsLowerLineFrame; i++)
        {
            Console.Write(userSymbol);
        }
    }
}
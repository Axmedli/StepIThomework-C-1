class Program
{
    static int rights = 0;

    static void SystemWait()
    {
        Console.WriteLine("Davam etmek ucun bir herf basin...");
        Console.ReadKey(true);
    }

    static void Rights()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Duzdur");
        Console.ResetColor();
        rights++;
    }
    static void Wrong()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sehvdir");
        Console.ResetColor();
    }

    static void Main()
    {
        Console.Write("1. Sual\n2 + 2 = ? necedir: ");
        int cavab1 = Convert.ToInt32(Console.ReadLine());
        if (cavab1 == 4) Rights();
        else Wrong();

        SystemWait();
        Console.Clear();

        Console.WriteLine("2. Sual\nHansi planet Guneşe en yaxindir?");
        Console.WriteLine("1. Mars");
        Console.WriteLine("2. Yupiter");
        Console.WriteLine("3. Venera");
        Console.WriteLine("4. Merkuri");
        int cavab2 = Convert.ToInt32(Console.ReadLine());
        if (cavab2 == 4) Rights();
        else Wrong();

        SystemWait();
        Console.Clear();

        Console.WriteLine("3. Sual\nHansi heyvanin uzun boynu var?");
        Console.WriteLine("1. Zurafe");
        Console.WriteLine("2. Timsah");
        Console.WriteLine("3. Zebra");
        Console.WriteLine("4. Panda");
        int cavab3 = Convert.ToInt32(Console.ReadLine());
        if (cavab3 == 1) Rights();
        else Wrong();

        SystemWait();
        Console.Clear();

        Console.WriteLine("4. Sual\nHansi elementin kimyevi simvolu 'O'dur?");
        Console.WriteLine("1. Hidrogen");
        Console.WriteLine("2. Karbon");
        Console.WriteLine("3. Oksigen");
        Console.WriteLine("4. Azot (Nitrogen)");
        int cavab4 = Convert.ToInt32(Console.ReadLine());
        if (cavab4 == 3) Rights();
        else Wrong();

        SystemWait();
        Console.Clear();

        Console.WriteLine("5. Sual\nHansi ölkenin paytaxti Parisdir?");
        Console.WriteLine("1. Fransa");
        Console.WriteLine("2. Amerika");
        Console.WriteLine("3. Turkiye");
        Console.WriteLine("4. Rusiya");
        int cavab5 = Convert.ToInt32(Console.ReadLine());
        if (cavab5 == 1) Rights(); 
        else Wrong();

        SystemWait();
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Duz cavablar: {rights}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Sehv cavablar: {5 - rights}");
        Console.ResetColor();
    }
}

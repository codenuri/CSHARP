using System;

class Program
{
    public static void Main()
    {
        int n = Console.Read();
        Console.WriteLine(n);

        //ConsoleKeyInfo cki = Console.ReadKey();
        ConsoleKeyInfo cki = Console.ReadKey(true);

        Console.WriteLine(cki.KeyChar);
    
    }
}




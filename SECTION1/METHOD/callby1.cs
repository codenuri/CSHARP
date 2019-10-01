using System;

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = n1;

        n2 = 20;

        Console.WriteLine($"{n1}, {n2}"); // 10, 20

        int n3 = 10;
        ref int n4 = ref n3;
            
        n4 = 20;

        Console.WriteLine($"{n3}, {n4}"); // 20, 20
    }
}
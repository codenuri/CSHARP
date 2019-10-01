using System;

class Program
{
    public static void inc1(int n) // int n = n1
    {
        ++n;
    }
    public static void inc2(ref int n) // ref int n = ref n2
    {
        ++n;
    }

    public static void Main()
    {
        int n1 = 10;
        inc1(n1);
        Console.WriteLine(n1);

        int n2 = 10;
        inc2(ref n2);
        Console.WriteLine(n2);

    }
}
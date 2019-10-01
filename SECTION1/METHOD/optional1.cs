using System;

class Program
{
    public static void foo(int a = 0, int b = 0, int c = 0)
    {
        Console.WriteLine($"{a}, {b}, {c}");
    }

    public static void Main()
    {
        foo(1, 2, 3);
        foo(1, 2);
        foo(1);
        foo();
        foo(b: 10);
        foo(c: 20);
    }

}
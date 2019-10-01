using System;

delegate void FUNC(int arg);

class Program
{
    static void Main()
    {
        int    n = 10; 
        double d = 3.4;   
        string s = "hello";

        FUNC f = foo;
        f(10); // foo(10)
        f.Invoke(10); // foo(10)
    }

    public static void foo(int arg)
    {
        Console.WriteLine($"foo : {arg}");
    }
}


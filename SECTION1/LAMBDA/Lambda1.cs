using System;

class Program
{
    public static void foo(Func<int, int, int> f)
    {
        int s = f(1, 2);
        Console.WriteLine(s);
    }
    static void Main(string[] args)
    {
        foo( Add );

        foo( (int a, int b) => { return a - b; }   );

    }
    public static int Add(int a, int b) { return a + b; }
    
}

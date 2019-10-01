using System;

class Program
{
    public static int Add(int a, int b) { return a + b; }

    static void Main()
    {
        Func<int, int, int> f1 = Add;

        Func<int, int, int> f2 = (int a, int b) => { return a + b; };

        Func<int, int, int> f3 = ( a,  b) => { return a + b; };

        Func<int, int, int> f4 = (a, b) => a + b;

        Func<int, int> f5 = (a) => a + a;

        Func<int, int> f6 = a => a + a; // Linq

    }

}

using System;

delegate int FUNC(int arg1, int arg2);

class Program
{
    public static int Add(int a, int b) { return a + b; }

    public static void Main()
    {
        //FUNC f = Add;

        FUNC f = delegate (int a, int b) { return a + b; };

        Console.WriteLine(f(1, 2));

        Foo(Add);
        Foo(delegate (int a, int b) { return a - b; });
    }


    public static void Foo(FUNC f) 
    {
        Console.WriteLine(f(1, 2));
    }
}



using System;

//delegate void Action<T>(T arg1);
//delegate void Action<T1, T2>(T1 arg1, T2 arg2);

//delegate TResult Func<TResult>();
//delegate TResult Func<T, TResult> (T arg1);
//delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);

class Program
{
    public static void Foo0() { }
    public static void Foo1(int arg1)           { }
    public static void Foo2(int arg1, int arg2) { }

    static void Main()
    {
        Action f0 = Foo0;
        Action<int> f1 = Foo1;
        Action<int, int> f2 = Foo2;

        Func<int> f3 = Goo0;
        Func<int, int> f4 = Goo1;
        Func<int, int,int> f5 = Goo2;
    }
    public static int Goo0() { return 0; }
    public static int Goo1(int arg1)           { return 0; }
    public static int Goo2(int arg1, int arg2) { return 0; }
}


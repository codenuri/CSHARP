using System;

class Test
{
    public static int Method1()
    {
        Console.WriteLine("Method1");
        return 1;
    }
    public static int Method2()
    {
        Console.WriteLine("Method2");
        return 2;
    }
    public static int Method3()
    {
        Console.WriteLine("Method3");
        return 3;
    }
    public static int Method4()
    {
        Console.WriteLine("Method4");
        return 4;
    }
}

delegate int FUNC();

class Program
{
    public static void Main()
    {
        FUNC uni = Test.Method1;

        int ret1 = uni();
        Console.WriteLine(ret1); // 1



        FUNC multi = Test.Method1;
        multi += Test.Method2;
        multi += Test.Method3;
        multi += Test.Method4;

        int ret2 = multi();
        Console.WriteLine(ret2); // 4

        //-------------------------
        Delegate[] arr = multi.GetInvocationList();

        foreach( Delegate d in arr)
        {
            FUNC f = (FUNC)d;
            int ret3 = f();
            Console.WriteLine(ret3);
        }
    }
}



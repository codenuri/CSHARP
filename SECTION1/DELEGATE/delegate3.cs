using System;

delegate void FUNC(int arg);

/*
class FUNC : System.MulticastDelegate
{
    //....
}
*/

class Program
{
    public static void Main()
    {
        FUNC f1 = new FUNC(foo); // 정확한 표기법
        f1.Invoke(10);       // 


        FUNC f2 = foo; 
        f2(10); // f2.Invoke(10)
    }

    public static void foo(int arg)
    {
        Console.WriteLine($"foo : {arg}");
    }
}



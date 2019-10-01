using System;

//void foo(int arg); // foo는 메소드(함수)

delegate void FUNC(int arg); // FUNC 은 타입
                    // 메소드의 호출정보를 담는 타입

class Program
{
    static void Main()
    {
        FUNC f = foo;
        f(10);
    }

    public static void foo(int arg)
    {
        Console.WriteLine($"foo : {arg}");
    }
}



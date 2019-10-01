using System;

class Program
{
    public void f1(int a = 0, int b = 0, int c = 0){}
    public void f2(int a,     int b = 0, int c = 0) { }

    // f3, f4는 error
    public void f3(int a, int b = 0, int c) { }
    public void f4(int a = 0, int b, int c = 0) { }


    public void f5(DateTime dt = DateTime.Now) { }
    public void f6(DateTime dt = new DateTime()) { }
    public void f7(DateTime dt = default(DateTime)) { }

    public static void Main()
    {
        f3(1, 2);
    }
}

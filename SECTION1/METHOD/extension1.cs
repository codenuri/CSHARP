using System;

class Car
{
    private int speed;
    public void Go() { Console.WriteLine("Go"); }

}
static class CarExtension
{
    public static void Stop(this Car c)
    {
    //    c.speed = 10; // error
    //    c.SetSpeed(10);
        Console.WriteLine("Stop");
    }
    public static void Foo(this Car c, int a, double d)
    {
        Console.WriteLine($"Foo {a} {d}");
    }
}
static class stringExtension
{
    public static void Stop(this string c)
    {
        //    c.speed = 10; // error
        //    c.SetSpeed(10);
        Console.WriteLine("Stop");
    }
    public static void Foo(this string c, int a, double d)
    {
        Console.WriteLine($"Foo {a} {d}");
    }
}
class Program
{
    public static void Main()
    {
        Car c = new Car();        
        c.Go(); // Go(c)
        c.Stop(); // CarExtension.Stop(c)
        c.Foo(3, 4.5);

        string s = "aaa";
        s.Foo(1, 1.2);
    }

}
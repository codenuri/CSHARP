using System;

class Base
{
    public int data1 = 10;
    public int data2 = 10;
}
class Derived : Base
{
    public new int data1 = 20;
}
class Program
{
    static void Main()
    {
        Derived d = new Derived();

        Console.WriteLine(d.data1); // 20
        Console.WriteLine(((Base)d).data1); // 10

    }
}

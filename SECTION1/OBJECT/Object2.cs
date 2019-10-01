using System;

class Car
{
}

class Program
{
    public static void Main()
    {
        Car c = new Car();

        Type t = c.GetType();

        t.ToString();

        t.FullName
        t.BaseType.FullName
    }
}
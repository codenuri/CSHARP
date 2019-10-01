using System;

class Car
{
    public int color = 10;
    public void Go() { Console.WriteLine("Go"); }
}

class Program
{
    public static Car CreateCar(int speed)
    {
        if (speed > 200) return null;
        return new Car();
    }
    public static void Main()
    {
        Car c = CreateCar(300) ?? new Car();


        int? n1 = 10; // null;// 10;

        //int n2 = n1; // error

        //int n2 = (int)n1; // ok

        int n2 = n1 ?? 0;

        Console.WriteLine(n2);

    }
}

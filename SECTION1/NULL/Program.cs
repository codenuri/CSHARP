using System;

class Car
{
    public int speed = 0;
    public void Go() { Console.WriteLine("Car Go"); }
}

class Program
{
    public static void Main()
    {
            Car c = new Car();
        //Car c = null;
      
        

        Console.WriteLine(c?.speed);
        Console.WriteLine("A");
        c?.Go();
        Console.WriteLine("B");

        c = null;

        int? n = c?.speed;

        Console.WriteLine(n);
        Console.WriteLine(c?.speed);

        Console.WriteLine("A");
        c?.Go();
        Console.WriteLine("B");
    }
}
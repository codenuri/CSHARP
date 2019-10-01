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
        Car c = CreateCar(300);

        //if ( c != null )
        //    c.Go();

        c?.Go();

        //int n = c.color;  // ok

        //int n = c?.color;  // error

        int? n = c?.color;
        //------------------
        int[] arr = null; // { 1, 2, 3 };

        //int n2 = arr[0];

        int? n2 = arr?[0]; // ?[
    }
}

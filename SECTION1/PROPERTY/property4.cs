using System;

class People
{
    private int age = 0; // 지원필드(Backing field)

    public int Age
    {
        get { return age; }
     //   protected set { age = value; }
    }

    public bool IsAdult
    {
        get { return age > 18; }
    }
}

class Program
{
    static void Main()
    {
        People p = new People();

        //p.Age = 10;
        Console.WriteLine(p.Age);

        if (p.IsAdult) { }
    }
}







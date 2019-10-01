using System;

class People
{
    private int age = 0;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    //public int get_Age() { return age; }
}

class Program
{
    static void Main()
    {
        People p = new People();
        p.Age = 10;
        int n2 = p.Age;
    }
}







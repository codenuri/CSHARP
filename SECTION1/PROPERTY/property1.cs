using System;

class People
{
    private int age = 0;

    public int  get_age() { return age; }
    public void set_age(int value)
    {
        if ( value <= 0 )
        {
            // 예외 전달
        }
        else
            age = value;
    }
}

class Program
{
    static void Main()
    {
        People p = new People();

        //p.age = 10;
        //p.age = -5;

        p.set_age(10);
        p.set_age(-5);
    }
}






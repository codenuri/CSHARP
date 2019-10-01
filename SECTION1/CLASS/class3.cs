using System;
using static System.Console;

class Base
{
    public virtual void Foo() { WriteLine("Base foo"); }
}
class Derived : Base
{
    //    public override void Foo() { WriteLine("Derived foo"); }


    //public new void Foo() { WriteLine("Derived foo"); }

    //public void Foo() { WriteLine("Derived foo"); }
    //public virtual void Foo() { WriteLine("Derived foo"); }
}

class Program
{
    static void Main()
    {
        Base b = new Derived();
        b.Foo();  
    }
}

using System;

class Base
{
    public void Foo() { Console.WriteLine("Base foo"); }
}
class Derived : Base
{
    public new void2 Foo() { Console.WriteLine("Derived foo"); }
}
class Program
{
    static void Main()
    {
        Base b1 = new Base();        
        b1.Foo();  // Base Foo

        Derived d1 = new Derived(); 
        d1.Foo();  // Derived Foo

        Base b2 = new Derived();
        b2.Foo();  // Base Foo ? Derived Foo(java)
                   // Base Foo(C#, C++)

    }
}

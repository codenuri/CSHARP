using System;

delegate void FUNC(int arg);

class Test
{
    public static void static_method(int arg) { }
    public void instance_method(int arg) { }
}
class Program
{
    public static void static_method(int arg) { }
    public void instance_method(int arg) { }

    public static void Main()
    {
        FUNC f1 = Test.static_method;
        //FUNC f2 = Program.static_method;
        FUNC f2 = static_method;

        Test t = new Test();
        FUNC f3 = t.instance_method;

        Program p = new Program();
        FUNC f4 = p.instance_method;

        p.foo();
    }
    public void foo()
    {
        FUNC f1 = this.instance_method;
        FUNC f2 = instance_method;
    }
}



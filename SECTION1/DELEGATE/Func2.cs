using System;

delegate void MyAction<T>(T arg1);

delegate TResult MyFunc<TResult>();

class Animal { }
class Dog : Animal { }


class Program
{
    public static Animal Foo1() { return new Animal(); }
    public static Dog Foo2()    { return new Dog(); }
    static void Main()
    {
        MyFunc<Animal> f1 = Foo1;
        MyFunc<Animal> f2 = Foo2;
    }
    public static void Goo1(Animal a) { }
    public static void Goo2(Dog d)    { }
}


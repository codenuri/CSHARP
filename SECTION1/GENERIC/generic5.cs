using System;

class Animal { }
class Dog : Animal { }

class Wrapper<in T>
{
    public T obj;
}

class Program
{
    static void Main()
    {
        Wrapper<Animal> wa = new Wrapper<Animal>();
        Wrapper<Dog>    wd = new Wrapper<Dog>();

        Wrapper<Animal> wa1 = wa;
        Wrapper<Animal> wa2 = wd;
        

    }
}


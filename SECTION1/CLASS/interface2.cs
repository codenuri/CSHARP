using System;

interface ICamera
{
    void Take();
}

class MP3
{
    public virtual void Play() { }
}

class SmartPhone : MP3, ICamera
{
    public override void Play() { }

    //public void Take() { }
    public virtual void Take() { }
}

class Program
{
    static void Main()
    {

    }
}

using System;

class Sentence
{
    private string[] words = null;

    public Sentence(string s) { words = s.Split(); }

    //public string Name
    public string this[ int idx ]
    {
        get { return words[idx]; }
        set { words[idx] = value; }
    }

    public override string ToString()
    {
        return string.Join(" ", words);
    }
}


class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

        s[0] = "Cat";

        Console.WriteLine(s[0]); // Cat
        Console.WriteLine(s);    // Cat is Animal

                // s.ToString()
                
                    
    }
}
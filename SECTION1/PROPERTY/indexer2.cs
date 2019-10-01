using System;

class Sentence
{
    private string[] words = null;
    public Sentence(string s) { words = s.Split(); }


    // property
    public string Name { get; set; } = "UNKNOWN";


    // indexer
    public string this[int idx]
    {
        get { return words[idx]; }
        set { words[idx] = value; }
    }
}



class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

        s[0] = "Cat";


    }
}
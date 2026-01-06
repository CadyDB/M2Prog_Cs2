namespace Dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program[];
        program.Run();
    }

    internal void Run()
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>( 
            personeelOpNummer.Add(382942, "jim"),
            personeelOpNummer.Add(789432, "tim")
        );

        string jim = personeelOpNummer[382942];
        string tim = personeelOpNummer[789432];

        foreach(KeyValuePair<int, string> item in personeelOpNummer)
        {
            return personeelOpNummer;
        }

        foreach(int key in personeelOpNummer.Keys)
        {
            
        }

        foreach(string value in personeelOpNummer.Values)
        {
            
        }
    }
}


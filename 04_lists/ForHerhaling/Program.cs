namespace ForHerhaling;

class Program
{
        double[] prijzen = new double[] {0.99, 5.60, 10.11};

        string [] artiekelen = {"snoepje", "luxe broodje", "lunch menu"};

        Formulier[] formulieren = new Formulier[2];

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
        
    }

    internal void Run()
    {
    
        formulieren[0] = new Formulier()
        {
            Feedback = "prijzig maar lekker",
            Sterren = 5
        };

        formulieren[1] = new Formulier()
        {
            Feedback = "lunch was wel erg veel",
            Sterren = 2
        };

        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(prijzen[i]);
            Console.WriteLine(artiekelen[i]);
        }
    }

    
}

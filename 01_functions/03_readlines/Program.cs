namespace _03_readlines;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Vraag1()
    {
        Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
        string antwoord = Console.Readline();

        Console.WriteLine(antwoord);
    }

    internal void Run()
    {
        Console.WriteLine("I can Survive atleast 2 hours");
        Console.WriteLine(Vraag1);
    }

}

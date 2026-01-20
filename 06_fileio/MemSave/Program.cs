using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using Microsoft.VisualBasic;

namespace MemSave;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run;
    }

    internal void Run()
    {
        string welkomsTekst = new string["Hello World"];
        Console.WriteLine(welkomsTekst);

        string[] saveFile = new string[welkomState.txt];
        bool bestaatDeFile = File.Exists(saveFile);


        while (true)
        {
            Console.WriteLine(welkomstekst);
            Console.WriteLine("Enter a text, then press enter");
            Console.ReadLine();

            File.WriteAllText(saveFile, welkomsTekst);
        }
    }
}

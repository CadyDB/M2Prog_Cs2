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
    string welkomsTekst = "Hello World";
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run;
    }

    private void Run()
    {
        Console.WriteLine(welkomsTekst);
        
        while (true)
        {
            Console.WriteLine("enter a text, then press enter");
            Console.ReadLine();        
        }
    }
}

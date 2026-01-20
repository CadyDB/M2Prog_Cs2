using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    string saveFile = welkomsTekst.txt;
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    private void Run()
    {

        bool bestaatDeFile = File.Exists(saveFile);
        if(bestaatDeFile--true)
        {
            Console.WriteLine("file exists");
            welkomsTekst = File.ReadAllText(saveFile);
        }
        Console.WriteLine(welkomsTekst);
        
        while (true)
        {
            Console.WriteLine("enter a text, then press enter");
            welkomsText= Console.ReadLine(); 
            File.WriteAllText(saveFile, welkomsTekst);      
        }
    }
}

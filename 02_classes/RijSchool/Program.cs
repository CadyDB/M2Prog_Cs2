namespace RijSchool;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        Auto auto1 = new Auto()
        {
          automaat = true,
          kenteken = "AA824H",
          kilometerStand = 20567,
          merk = "volkswagen"  
        };

        Auto auto2 = new Auto()
        {
          automaat = false,
          kenteken = "KU786G",
          kilometerStan = 65739,
          merk = "volvo"  
        };

        RijLeraar rijLeraar = new RijLeraar()
        {
          leeftijd = 30,
          naam = "John",
          zzp = false
        };

        LesUur lesUur = new LesUur()
        {
          auto1 = auto1,
          rijLeraar = rijLeraar,
          tijd = 1130  
        };
        
        LesUur lesUur2 = new LesUur()
        {
          auto2 = auto2,
          rijLeraar = rijLeraar,
          tijd = 1302  
        };

        Student student = new Student()
        {
          lesPakket = lesPakket,
          theorieTest = theorieTest,
          rijTest = rijTest,
          rijLeraar = rijLeraar,
          lesUur = lesUur,
          auto1 = auto1  
        };
        
        Student student2 = new Student()
        {
          lesPakket = lesPakket,
          theorieTest = theorieTest,
          rijTest = rijTest,
          rijLeraar = rijLeraar,
          lesUur = lesUur2, 
          auto2 = auto2
        };

        Dag dag = new Dag()
        {
          lesUur = {lesUur},
        };
    }
}

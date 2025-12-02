namespace Constructor;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program[];
        program.Run();
    }

    internal Quiz()
    {
        int aantalVragen;
        aantalVragen = new QuizVraag[aantalVragen];
        aantalVragen = new QuizVraagAntwoord[ingevuldeAntwoorden];
    }

    internal QuizVraagAntwoord(QuizVraag vraag)
    {
        vraag = vraag;
        goed = false;
    }

    private void Run()
    {
        QuizVraag quizVraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        Quiz quiz = new Quiz(10);
    }

}

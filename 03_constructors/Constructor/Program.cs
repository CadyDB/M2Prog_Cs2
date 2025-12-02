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
        QuizVraag quizVraag = new QuizVraag(vraag, antwoord);
        Quiz quiz = new Quiz(10);
        quiz.VoegVraagToeOpIndex(0, quizVraag);
    }

}

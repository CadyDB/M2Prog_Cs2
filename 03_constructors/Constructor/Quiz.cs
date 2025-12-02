namespace Constructor;

class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

    void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }

    void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        
    }
    void StelVraag(int index)
    {
        QuizVraag vraag = vragen[index];
        QuizVraagAntwoord quizVraagAntwoord = new QuizVraagAntwoord(vraag);
        
        Console.WriteLine(vraag.vraag);
        string antwoord = Console.ReadLine();
    }

}
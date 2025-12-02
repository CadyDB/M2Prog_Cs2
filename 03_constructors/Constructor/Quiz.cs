namespace Constructor;

class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

    void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        QuizVraag quizVraag = new QuizVraag[];
        vragen[index] = vraag;
        vragen[index] = vraag;
        vragen[index] = vraag;
        vragen[index] = vraag;
        vragen[index] = vraag;
    }

    void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag quizVraag = new QuizVraag[];
        vragen[index] = vraag;
        vragen[index] = vraag;
        vragen[index] = vraag;
        vragen[index] = vraag;
        vragen[index] = vraag;
    }
}
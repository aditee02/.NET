class Question

{

    public string questionText;

    public string optionA;

    public string optionB;

    public string optionC;

    public string optionD;

    public char correctAnswerLetter;

    private static char defaultCorrectAnswerLetter = 'X';



    public Question()

    {

        this.questionText = null;

        this.optionA = null;

        this.optionB = null;

        this.optionC = null;

        this.optionD = null;

        this.correctAnswerLetter = defaultCorrectAnswerLetter;



    }



    public Question(string questionText)

    {

        this.questionText = questionText;

        this.optionA = null;

        this.optionB = null;

        this.optionC = null;

        this.optionD = null;

        this.correctAnswerLetter = defaultCorrectAnswerLetter;



    }



    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)

    {

        this.questionText = questionText;

        this.optionA = optionA;

        this.optionB = optionB;

        this.optionC = optionC;

        this.optionD = optionD;

        if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D')
        {

            this.correctAnswerLetter = correctAnswerLetter;

        }



    }



    public bool AreOptionsValid()

    {

        int count = 0;

        if (optionA != null)

            count++;

        if (optionB != null)

            count++;

        if (optionC != null)

            count++;

        if (optionD != null)

            count++;

        if (count > 2)
        {

            return true;

        }
        else
        {

            return false;

        }



    }

}



class Program

{

    static void Main()

    {

        Question obj1 = new Question();

        Question obj2 = new Question("Color of Sky?");

        Question obj3 = new Question("Color of Sky?", "Red", "Blue", "Black", "Pink", 'B');

        Question obj4 = new Question("Color of Sky?", "Red", "Blue", "Black", "Pink");

    }

}

using System.Dynamic;

namespace system
{

public class Summary
{

        public string Writing;
        public int QuestionsAnswered;


        public Summary (string weather, string decision)
        {
            QuestionsAnswered = 0;
            Writing = $"The weather is {weather}, You made the decision to {decision}!";
        }

        public void AddQuestion()
        {
            QuestionsAnswered++;
        }
        public void PrintWriting()
        {
            Console.WriteLine(QuestionsAnswered);
            Console.WriteLine($"Summary: {Writing}");
        }
}

}


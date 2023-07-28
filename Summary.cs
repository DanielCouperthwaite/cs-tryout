
using System.Dynamic;

namespace system
{

public class Summary
{

        public string Writing;


        public Summary (string weather, string decision)
        {

            Writing = $"The weather is {weather}, You made the decision to {decision}!";
        }

        public void PrintWriting()
        {
            Console.WriteLine($"Summary: {Writing}");
        }
}

}


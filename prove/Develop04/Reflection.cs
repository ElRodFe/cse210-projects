using System.Diagnostics;
using System.Net.Http.Headers;

public class ReflectionActivity: Activity {
    private List<string> _promptsList = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();
    private List<int> _printedQuestionsIndexes = new List<int>();

    public ReflectionActivity() {
        _name = "Reflectiion Activity";
        _description = "This activity will help you reflect on times in your life when you have shown\n strength and resilience. This will help you recognize the power you have and how you can use it\n in other aspects of your life";

        //Populating prompts list
        _promptsList.Add("Think of a time when you stood up for someone else.");
        _promptsList.Add("Think of a time when you did something really difficult.");
        _promptsList.Add("Think of a time when you helped someone in need.");
        _promptsList.Add("Think of a time when you did something truly selfless.");

        //Populating questions list
        _reflectionQuestions.Add("Why was this experience meaningful to you?");
        _reflectionQuestions.Add("Have you ever done anything like this before?");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectionQuestions.Add("What is your favorite thing about this experience?");
        _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestions.Add("What did you learn about yourself through this experience?");
        _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    }

    public void GetRandomPrompt() {
        Random rnd = new Random();
        int index;
        index = rnd.Next(0, _promptsList.Count());

        Console.WriteLine(_promptsList[index]);
    }

    public void GetRandomQuestion() {
        Random rnd = new Random();
        int index;
        do {
            index = rnd.Next(0, _reflectionQuestions.Count());
        } while (_printedQuestionsIndexes.Contains(index));

        _printedQuestionsIndexes.Add(index);
        Console.WriteLine(_reflectionQuestions[index]);
    }

    public void StartReflecting() {
        DisplayStartMsg();
        Console.WriteLine();
        Stopwatch timer = new Stopwatch();
        DisplaySpinner(5);

        timer.Start();
        GetRandomPrompt();
        DisplaySpinner(8);
        do {
            Console.WriteLine();

            GetRandomQuestion();
            DisplaySpinner(10);

        } while (timer.Elapsed.TotalSeconds < _duration);
        timer.Stop();
        Console.WriteLine();

        DisplayEndMsg();
        DisplaySpinner(3);
        Console.WriteLine();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt questions = new Prompt();
        questions._prompts.Add("Who was the most interesting person I interacted with today?");
        questions._prompts.Add("What was the best part of my day?");
        questions._prompts.Add("How did I see the hand of the Lord in my life today?");
        questions._prompts.Add("What was the strongest emotion I felt today?");
        questions._prompts.Add("If I had one thing I could do over today, what would it be?");
    }
}
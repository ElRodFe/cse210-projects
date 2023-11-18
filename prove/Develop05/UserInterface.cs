using System.Runtime.InteropServices;

public class UserInterface {
    private string _fileName = "";
    private int _totalPoints = 0;
    private List<Goal> _goalsList = new List<Goal>();
    private SimpleGoal sG = new SimpleGoal("", "", 0);
    private EternalGoal eG = new EternalGoal("", "", 0);
    private CheckListGoal cG = new CheckListGoal("", "", 0, 0, 0, 0);

    public void SetFileName(string fileName) {
        _fileName = fileName;
    }

    public string GetFileName() {
        return _fileName;
    }

    public void Menu() {
        string userChoice = "";
        while (userChoice != "6") {
            Console.WriteLine($"You have: {_totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
            Console.Write("Select an option from the menu: ");
            userChoice = Console.ReadLine();
            Console.WriteLine();

            if (userChoice == "1") {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
                Console.Write("Which type of goal do you want to create?: ");
                userChoice = Console.ReadLine();

                if (userChoice == "1") {
                    sG.CreateGoal();
                    _goalsList.Add(sG);
                    Console.WriteLine();
                }
                else if (userChoice == "2") {
                    eG.CreateGoal();
                    _goalsList.Add(eG);
                    Console.WriteLine();
                }
                else if (userChoice == "3") {
                    cG.CreateGoal();
                    _goalsList.Add(cG);
                    Console.WriteLine();
                }
                else {
                    Console.WriteLine("Invalid Choice");
                    Console.WriteLine();
                }
            }
            else if (userChoice == "2") {
                foreach (Goal goal in _goalsList) {
                    if (goal.GetCompleted() == true) {
                        if (goal is CheckListGoal gC) {
                            Console.WriteLine($"[X] {goal.GetName()}: {goal.GetDescrpition()} | Points worth: {goal.GetPoints()} | Times to complete: {gC.GetTimesCompleted()}/{gC.GetTimesToComplete()}");
                        }
                        else {
                            Console.WriteLine($"[X] {goal.GetName()}: {goal.GetDescrpition()} | Points worth: {goal.GetPoints()}");
                        }
                    }
                    else if (goal.GetCompleted() == false) {
                        if (goal is CheckListGoal gC) {
                        Console.WriteLine($"[ ] {goal.GetName()}: {goal.GetDescrpition()} | Points worth: {goal.GetPoints()} | Times to complete: {gC.GetTimesCompleted()}/{gC.GetTimesToComplete()}");
                        }
                        else {
                            Console.WriteLine($"[ ] {goal.GetName()}: {goal.GetDescrpition()} | Points worth: {goal.GetPoints()}");
                        }
                    }
                }
            }
            else if (userChoice == "3") {
                SaveFile();
                Console.WriteLine();
            }
            else if (userChoice == "4") {
                LoadFile();
                Console.WriteLine();
            }
            else if (userChoice == "5") {
                Console.WriteLine("The goals are: ");
                Console.WriteLine($"1. {sG.GetName()} \n2. {eG.GetName()} \n3. {cG.GetName()}");
                Console.Write("Which goal did you accomplish?: ");
                userChoice = Console.ReadLine();

                if (userChoice == "1") {
                    if (sG.GetCompleted() == true) {
                        Console.WriteLine("Goal Already Completed.");
                    }
                    else {
                        sG.RecordEvent();
                        _totalPoints += sG.GetPoints();
                        Console.WriteLine();
                    }
                }
                else if(userChoice == "2") {
                    eG.RecordEvent();
                    _totalPoints += eG.GetPoints();
                    Console.WriteLine();
                }
                else if(userChoice == "3") {
                    if (cG.GetCompleted() == true) {
                        Console.WriteLine("Goal already completed.");
                    }
                    else {
                        cG.RecordEvent();
                        cG.CheckIfCompleted();
                        if (cG.GetCompleted() == true) {
                            _totalPoints += cG.GetPoints();
                            _totalPoints += cG.GetBonus();
                        }
                        else if (cG.GetCompleted() == false) {
                            _totalPoints += cG.GetPoints();
                        }
                        Console.WriteLine();
                    }
                }
                else {
                    Console.WriteLine("Invalid Choice");
                    Console.WriteLine();
                }
            }
            else if (userChoice == "6") {
                Environment.Exit(0);
            }
            else {
                    Console.WriteLine("Invalid Choice");
                    Console.WriteLine();
                }
        }
    }

    public void SaveFile() {
        Console.Write("What is the name of the file (for example 'mygoals.txt')?: ");
        _fileName = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(_fileName)) {
            file.WriteLine($"{_totalPoints}");
            foreach (Goal goal in _goalsList) {
                if (goal is CheckListGoal clg) {
                    file.WriteLine($"Checklist Goal | {clg.GetName()} | {clg.GetDescrpition()} | {clg.GetPoints()} | {clg.GetBonus()} | {clg.GetTimesCompleted()} | {clg.GetTimesToComplete()}");
                }
                else if (goal is SimpleGoal sg) {
                    file.WriteLine($"Simple Goal | {sg.GetName()} | {sg.GetDescrpition()} | {sg.GetPoints()} | {sg.GetCompleted()}");
                }
                else if (goal is EternalGoal eg) {
                    file.WriteLine($"Eternal Goal | {eg.GetName()} | {eg.GetDescrpition()} | {eg.GetPoints()}");
                }
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadFile() {
        Console.Write("What is the name of the file (for example 'mygoals.txt')?: ");
        _fileName = Console.ReadLine();

        if (File.Exists(_fileName)) {
            using (StreamReader file = new StreamReader(_fileName)) {
                _totalPoints = int.Parse(file.ReadLine());

                _goalsList.Clear();
                while (!file.EndOfStream) {
                    string[] data = file.ReadLine().Split("|").Select(s => s.Trim()).ToArray();

                    string goalType = data[0];
                    string name = data[1];
                    string description = data[2];
                    int goalPoints = int.Parse(data[3]);

                    switch (goalType) {
                        case "Simple Goal":
                            bool completed = bool.Parse(data[4]);
                            sG.SetName(name);
                            sG.SetDescription(description);
                            sG.SetGoalPoints(goalPoints);
                            sG.SetCompleted(completed);
                            _goalsList.Add(sG);
                            break;
                        case "Eternal Goal":
                            eG.SetName(name);
                            eG.SetDescription(description);
                            eG.SetGoalPoints(goalPoints);
                            _goalsList.Add(eG);       
                            break;
                        case "Checklist Goal":
                            int timesCompleted = int.Parse(data[5]);
                            int timesToComplete = int.Parse(data[6]);
                            int bonus = int.Parse(data[4]);
                            cG.SetName(name);
                            cG.SetDescription(description);
                            cG.SetGoalPoints(goalPoints);
                            cG.SetTimesToComplete(timesToComplete);
                            cG.SetTimesCompleted(timesCompleted);
                            cG.SetBonus(bonus);
                            _goalsList.Add(cG);
                            break;
                        default:
                            Console.WriteLine($"Unsuported goal type: {goalType}");
                            continue;
                    }
                }
            }
            Console.WriteLine("Goals loaded");
        }
        else {
            Console.WriteLine("File not found. Please make sure the file exists and try again.");
        }
    }
}

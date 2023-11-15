public class UserInterface {
    private string _fileName = "";
    private List<Goal> _goalsList = new List<Goal>();

    public void SetFileName(string fileName) {
        _fileName = fileName;
    }

    public string GetFileName() {
        return _fileName;
    }

    public void Menu() {
        SimpleGoal sG = new SimpleGoal("", "", 0);
        EternalGoal eG = new EternalGoal("", "", 0);
        CheckListGoal cG = new CheckListGoal("", "", 0, 0, 0);

        string userChoice = "";
        while (userChoice != "6") {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
            Console.Write("Select an option from the menu: ");
            userChoice = Console.ReadLine();

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
                    if (goal is CheckListGoal gC) {
                        Console.WriteLine($"[ ] {goal.GetName()}: {goal.GetDescrpition()} | Points worth: {goal.GetPoints()} | Times to complete: {gC.GetTimesCompleted()}/{gC.GetTimesToComplete()}");
                    }
                    else {
                        Console.WriteLine($"[ ] {goal.GetName()}: {goal.GetDescrpition()} | Points worth: {goal.GetPoints()}");
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
                    sG.RecordEvent();
                    Console.WriteLine();
                }
                else if(userChoice == "2") {
                    eG.RecordEvent();
                    Console.WriteLine();
                }
                else if(userChoice == "3") {
                    cG.RecordEvent();
                    Console.WriteLine();
                }
                else {
                    Console.WriteLine("Invalid Choice");
                    Console.WriteLine();
                }
                
            }
            else {
                    Console.WriteLine("Invalid Choice");
                    Console.WriteLine();
                }
        }
    }

    public void SaveFile() {

    }

    public void LoadFile() {

    }
}
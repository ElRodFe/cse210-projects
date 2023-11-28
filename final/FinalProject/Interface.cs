public class Interface {
    private string _fileName = "";
    private List<Recipe> _listOfRecipes = new List<Recipe>();

    public void Menu(string userChoice) {
        switch (userChoice) {
            case "1":
                Console.WriteLine("Which type of recipe will you add?");
                Console.WriteLine("1- Breakfast Recipe \n2- Lunch Recipe \n3- Dinner Recipe");
                Console.Write("Select an option: ");
                userChoice = Console.ReadLine();
                Console.WriteLine();
                switch (userChoice) {
                    case "1":
                    string bTitle = "";
                        Console.Write("What is the recipe's name?: ");
                        bTitle = Console.ReadLine();
                        BreakfastRecipe bR = new BreakfastRecipe(bTitle);
                        bR.AddRecipe();
                        _listOfRecipes.Add(bR);
                        Console.WriteLine();                   
                        break;
                    case "2":
                        string lTitle = "";
                        Console.Write("What is the recipe's name?: ");
                        lTitle = Console.ReadLine();
                        LunchRecipe lR = new LunchRecipe(lTitle);
                        lR.AddRecipe();
                        _listOfRecipes.Add(lR);
                        Console.WriteLine();
                        break;
                    case "3":
                        string dTitle = "";
                        Console.Write("What is the recipe's name?: ");
                        dTitle = Console.ReadLine();
                        DinnerRecipe dR = new DinnerRecipe(dTitle);
                        dR.AddRecipe();
                        _listOfRecipes.Add(dR);
                        Console.WriteLine();
                        break;
                }
                break;
            
            case "2":
                Console.WriteLine("Which category of recipes do you want to display?:");
                Console.WriteLine("1- Breakfast Recipe \n2- Lunch Recipe \n3- Dinner Recipe");
                Console.Write("Select an option: ");
                userChoice = Console.ReadLine();
                if (userChoice == "1") {
                    foreach (Recipe recipe in _listOfRecipes) {
                        if (recipe is BreakfastRecipe) {
                            DisplayRecipe(recipe);
                        }
                    }
                }
                else if (userChoice == "2") {
                    foreach (Recipe recipe in _listOfRecipes) {
                        if (recipe is LunchRecipe) {
                            DisplayRecipe(recipe);
                        }
                    }
                }
                else if (userChoice == "3") {
                    foreach (Recipe recipe in _listOfRecipes) {
                        if (recipe is DinnerRecipe) {
                            DisplayRecipe(recipe);
                        }
                    }
                }
                break;
        }
    }
    public void SaveFile() {

    }
    public void LoadFile() {

    }
    public void DisplayRecipe(Recipe recipeType) {
        recipeType.DisplayDetails();
        Console.WriteLine();
        }
}

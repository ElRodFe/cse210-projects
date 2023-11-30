public class Recipe {
    protected string _title = "";
    protected string _categoryName = "";
    protected List<Ingredient> _ingredients = new List<Ingredient>();
    protected string _instructions = "";
    protected string _cookingTime = "";
    protected DifficultyLevel _difficultyLevel = new DifficultyLevel("", "");

    public string GetName() {
        return _title;
    }
    public void SetInstructions(string newInstructions) {
        _instructions = newInstructions;
    }

    public void AddRecipe() {
        int numberOfIngredients = 0;
        int i = 1;
        AddDifficultyLevel();
        Console.WriteLine();
        Console.WriteLine("How many ingredients the recipe has?: ");
        numberOfIngredients = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while ( i <= numberOfIngredients) {
            Console.WriteLine($"Ingredient N° {i}");
            Console.WriteLine();
            AddIngredient();
            i++;
        }
        Console.WriteLine();

        Console.WriteLine("Please enter the instructions for cooking");
        Console.Write("Instructions: ");
        _instructions = Console.ReadLine();
        Console.WriteLine();

        Console.Write("How many minutes needs to be baking or freezing? (leave it empty if there's no need of it): ");
        _cookingTime = Console.ReadLine();

    }
    public void AddIngredient() {
        string ingredientName = "";
        Console.Write("What is the ingredient's name?: ");
        ingredientName = Console.ReadLine();

        string unitOfMeasurement = "";
        Console.Write("What is it's unit of measurement?: ");
        unitOfMeasurement = Console.ReadLine();

        string quantity = "";
        Console.Write($"How many {unitOfMeasurement} will be needed?: ");
        quantity = Console.ReadLine();

        Ingredient ingredient = new Ingredient(ingredientName, unitOfMeasurement, quantity);
        _ingredients.Add(ingredient);
        Console.WriteLine();
    }
    public void AddDifficultyLevel() {
        string uC = "";
        while (uC != "1" || uC != "2" || uC != "3") {
            Console.WriteLine("What is the difficulty level for ths recipe?: ");
            Console.WriteLine("1- Begginer \n2- Intermediate \n3- Advanced");
            uC = Console.ReadLine();

            if (uC == "1") {
                _difficultyLevel = new DifficultyLevel("Begginer", "For people who just started learning to cook");
                break;
            }
            else if (uC == "2") {
                _difficultyLevel = new DifficultyLevel("Intermediate", "For those who know how to cook");
                break;
            }
            else if (uC == "3") {
                _difficultyLevel = new DifficultyLevel("Advanced", "For those who really knows the art of cooking");
                break;
            }
            else {
                Console.WriteLine("Invalid Option.");
            }
        }
    }
    public void EditInstructions() {
        string newInstructions = "";
        Console.WriteLine("Please enter the new instructions: ");
        Console.Write("New Instructions: ");
        newInstructions = Console.ReadLine();

        SetInstructions(newInstructions);
    }
    public void DisplayDetails() {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Category: {_categoryName}");
        Console.WriteLine($"Difficulty Level: {_difficultyLevel.DisplayDetails()}");
        Console.WriteLine("Ingredients:");
        foreach (Ingredient ingredient in _ingredients) {
            Console.WriteLine($"-{ingredient.DisplayDetails()}");
        }
        Console.WriteLine($"Baking or Freezing time: {_cookingTime}");
        Console.WriteLine();
        Console.WriteLine($"Instructions: {_instructions}");
    }

}
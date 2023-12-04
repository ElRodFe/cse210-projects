using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
                Console.WriteLine();
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
            
            case "3":
                int indexNumber = 1;
                int uC = 0;
                Console.WriteLine("Which recipe you want to edit?");
                foreach (Recipe recipe in _listOfRecipes) {
                    Console.WriteLine($"{indexNumber}- {recipe.GetTitle()}");
                    indexNumber ++;
                }
                Console.Write("Select an option: ");
                uC = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int selectedRecipeIndex = uC - 1;

                Console.WriteLine("What you want to do?");
                Console.WriteLine("1- Edit Instructions \n2- Delete Recipe");
                Console.WriteLine("Select an option: ");
                userChoice = Console.ReadLine();
                if (userChoice == "1") {
                    _listOfRecipes[selectedRecipeIndex].EditInstructions();
                }
                else if (userChoice == "2") {
                    _listOfRecipes.RemoveAt(selectedRecipeIndex);
                }
                Console.WriteLine();
                break;
            
            case "4":
                SaveFile();
                break;
            case "5":
                LoadFile();
                break;
        }
    }
    public void SaveFile() {
        Console.Write("What is the name for the file? (example: myrecipes.txt): ");
        _fileName = Console.ReadLine();
        Console.WriteLine();

        SerializeToFile(_listOfRecipes);
        Console.WriteLine($"File saved to {_fileName}");

    }
    public void LoadFile() {
        _listOfRecipes.Clear();
        Console.Write("What is the name of the file? (example: myrecipes.txt): ");
        _fileName = Console.ReadLine();
        Console.WriteLine();

        _listOfRecipes = DeserializeFromFile();
        Console.WriteLine("File Loaded");

    }
    public void DisplayRecipe(Recipe recipeType) {
        recipeType.DisplayDetails();
        Console.WriteLine();
        }
    public void SerializeToFile(List<Recipe> data) {
        
        using (StreamWriter writer = new StreamWriter(_fileName)) {
            foreach (Recipe recipe in data) {
                writer.WriteLine($"Title: {recipe.GetTitle()}");
                writer.WriteLine($"Category: {recipe.GetCategoryName()}");
                writer.WriteLine($"DifficultyLevel: {recipe.GetDifficultyLevel()}");
                writer.WriteLine($"CookingTime: {recipe.GetCookingTime()}");
                writer.WriteLine($"Instructions: {recipe.GetInstructions()}");
                
                writer.WriteLine("Ingredients:");
                foreach (Ingredient ingredient in recipe.GetIngredients()) {
                    writer.WriteLine($"{ingredient.DisplayDetails()}");
                }

                writer.WriteLine(new string ('-', 30));
            }
        }
    }
    public List<Recipe> DeserializeFromFile() {
        List<Recipe> recipes = new List<Recipe>();

        using (StreamReader reader = new StreamReader(_fileName)) {
            while(!reader.EndOfStream) {
                string title = ReadValue(reader.ReadLine());
                string category = ReadValue(reader.ReadLine());
                string difficultyInfo = ReadValue(reader.ReadLine());
                string cookingTime = ReadValue(reader.ReadLine());
                string instructions = ReadValue(reader.ReadLine());

                DifficultyLevel difficultyLevel = ParseDifficultyLevel(difficultyInfo);
                List<Ingredient> ingredients = new List<Ingredient>();
                string line;
                while ((line = reader.ReadLine()) != new string('-', 30).ToString()) {
                    if (line.Trim().Equals("Ingredients:", StringComparison.OrdinalIgnoreCase)){
                        continue;
                    }
                    ingredients.Add(ParseIngredient(line));
                }
                
                Recipe recipe; 
                switch (category) {
                    case "Breakfast":
                        recipe = new BreakfastRecipe(title, ingredients, instructions, cookingTime, difficultyLevel);
                        recipes.Add(recipe);
                        break;
                    case "Lunch":
                        recipe = new LunchRecipe(title, ingredients, instructions, cookingTime, difficultyLevel);
                        recipes.Add(recipe);
                        break;
                    case "Dinner":
                        recipe = new DinnerRecipe(title, ingredients, instructions, cookingTime, difficultyLevel);
                        recipes.Add(recipe);
                        break;             
                }
            }

            return recipes;
        }
    }
    private string ReadValue(string line) {
        return line.Split(':').LastOrDefault()?.Trim();
    }

    private Ingredient ParseIngredient(string line) {

        string[] parts = line.Split(" ");
        if (parts.Length >= 4) {
            string quantity = parts[0];
            string unitOfMeasurement = parts[1];
            string name = string.Join(" ", parts.Skip(2));

            return new Ingredient(name, unitOfMeasurement, quantity);
        }
        throw new FormatException($"Invalid ingredient format: {line}");
    }

    private DifficultyLevel ParseDifficultyLevel(string difficultyInfo) {
        string[] parts = difficultyInfo.Split("(");
        if (parts.Length == 2) {
            string difficulty = parts[0].Trim();
            string description = parts[1].Trim(' ', ')');
            return new DifficultyLevel(difficulty, description);
        }
        throw new FormatException($"Invalid difficulty level format: {difficultyInfo}");
    }
        
}

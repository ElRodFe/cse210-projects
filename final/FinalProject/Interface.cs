using System;
using System.Collections.Generic;
using System.IO;
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
        }
    }
    public void SaveFile() {
        Console.Write("What is the name for the file? (example: myrecipes.json): ");
        _fileName = Console.ReadLine();
        Console.WriteLine();

        SerializeToFile(_listOfRecipes);
        Console.WriteLine($"File saved to {_fileName}");

    }
    public void LoadFile() {

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
                writer.WriteLine($"Difficulty Level: {recipe.GetDifficultyLevel()}");
                writer.WriteLine($"Cooking Time: {recipe.GetCookingTime()}");
                writer.WriteLine($"Instructions: {recipe.GetInstructions()}");
                
                writer.WriteLine("Ingredients:");
                foreach (Ingredient ingredient in recipe.GetIngredients()) {
                    writer.WriteLine($"{ingredient.DisplayDetails()}");
                }

                writer.WriteLine(new string ('-', 30));
            }
        }
    }
}

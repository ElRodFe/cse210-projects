public class LunchRecipe: Recipe {

    public LunchRecipe(string title) {
        _title = title;
        _categoryName = "Lunch";
    }

    public LunchRecipe(string title, List<Ingredient> ingredients, string instructions, string cookingTime, DifficultyLevel difficultyLevel) {
    _title = title;
    _categoryName = "Lunch";
    _ingredients = ingredients;
    _instructions = instructions;
    _cookingTime = cookingTime;
    _difficultyLevel = difficultyLevel;
    }
    
}
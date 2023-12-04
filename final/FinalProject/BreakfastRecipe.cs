public class BreakfastRecipe: Recipe {
    public BreakfastRecipe(string title) {
        _title = title;
        _categoryName = "Breakfast";
    }

    public BreakfastRecipe(string title, List<Ingredient> ingredients, string instructions, string cookingTime, DifficultyLevel difficultyLevel) {
    _title = title;
    _categoryName = "Breakfast";
    _ingredients = ingredients;
    _instructions = instructions;
    _cookingTime = cookingTime;
    _difficultyLevel = difficultyLevel;
    }
}
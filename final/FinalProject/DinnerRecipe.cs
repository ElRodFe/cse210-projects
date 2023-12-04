public class DinnerRecipe: Recipe {

    public DinnerRecipe(string title) {
        _title = title;
        _categoryName = "Dinner";

    }

    public DinnerRecipe(string title, List<Ingredient> ingredients, string instructions, string cookingTime, DifficultyLevel difficultyLevel) {
    _title = title;
    _categoryName = "Dinner";
    _ingredients = ingredients;
    _instructions = instructions;
    _cookingTime = cookingTime;
    _difficultyLevel = difficultyLevel;
    }
    
}
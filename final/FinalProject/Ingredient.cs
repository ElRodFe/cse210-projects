public class Ingredient {
    private string _name;
    private string _unitOfMeasurement;
    private double _quantity;

    public Ingredient(string name, string unitOfMeasurement, double quantity){
        _name = name;
        _unitOfMeasurement = unitOfMeasurement;
        _quantity = quantity;
    }

    public void UpdateQuantity() {

    }
    public string DisplayDetails(){
        return "";
    }

}
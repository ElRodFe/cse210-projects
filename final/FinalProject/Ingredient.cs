public class Ingredient {
    private string _name;
    private string _unitOfMeasurement;
    private string _quantity;

    public Ingredient(string name, string unitOfMeasurement, string quantity){
        _name = name;
        _unitOfMeasurement = unitOfMeasurement;
        _quantity = quantity;
    }

    public void UpdateQuantity() {

    }
    public string DisplayDetails(){
        return $"{_quantity} {_unitOfMeasurement} of {_name}";
    }

}
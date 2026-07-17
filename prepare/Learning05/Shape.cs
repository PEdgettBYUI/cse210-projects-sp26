public abstract class Shape {
    // Attributes
    private string _color_PTE;


    // Setters and Getters
    public string GetColor(){
        return _color_PTE;
    }
    public void SetColor(string color) {
        _color_PTE = color;
    }


    // Constructor
    public Shape( string color) {
        _color_PTE = color;
    }
    

    // Methods
    public abstract double GetArea();
}
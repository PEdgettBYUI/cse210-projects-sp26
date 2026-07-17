public class Square : Shape {
    // Attributes
    private double _side_PTE;

    // Setters and Getters


    // Constructor
    public Square(string color, double side) : base(color) {
        _side_PTE = side;
    }

    // Methods
    public override double GetArea() {
        return _side_PTE * _side_PTE;
    }

}

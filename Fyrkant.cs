namespace Labb7
{
    // Create a class named Fyrkant that inherits from Geometri
    public class Fyrkant : Geometri
    {
        // Add a property for Fyrkant
        public double SideLength { get; set; }

        // Constructor for Fyrkant class
        public Fyrkant()
        {
            SideLength = 5;  // Set a default value for SideLength
        }

        // Override the Area method for Fyrkant
        public override double Area()
        {
            return SideLength * SideLength;
        }
    }
}

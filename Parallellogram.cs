namespace Labb7
{
    // Create a class named Parallellogram that inherits from Geometri
    public class Parallellogram : Geometri
    {
        // Add a property for Parallellogram
        public double Base { get; set; }
        public double Height { get; set; }

        // Constructor for Parallellogram class
        public Parallellogram()
        {
            Base = 6;    // Set a default value for Base
            Height = 4;  // Set a default value for Height
        }

        // Override the Area method for Parallellogram
        public override double Area()
        {
            return Base * Height;
        }
    }
}

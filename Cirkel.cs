namespace Labb7
{
    // Create a class named Cirkel that inherits from Geometri
    public class Cirkel : Geometri
    {
        // Add a property for Cirkel
        public double Radius { get; set; }

        // Constructor for Cirkel class
        public Cirkel()
        {
            Radius = 4;  // Set a default value for Radius
        }

        // Override the Area method for Cirkel
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

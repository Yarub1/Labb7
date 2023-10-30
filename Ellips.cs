namespace Labb7
{
    // Create a class named Ellips that inherits from Geometri
    public class Ellips : Geometri
    {
        // Add properties for Ellips
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        // Constructor for Ellips class
        public Ellips()
        {
            MajorAxis = 8;  // Set a default value for MajorAxis
            MinorAxis = 4;  // Set a default value for MinorAxis
        }

        // Override the Area method for Ellips
        public override double Area()
        {
            return Math.PI * MajorAxis * MinorAxis;
        }
    }
}

namespace Labb7
{
    // Create a class named Rektangel that inherits from Geometri
    public class Rektangel : Geometri
    {
        // Add a property for Rektangel
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor for Rektangel class
        public Rektangel()
        {
            Length = 5;  // Set a default value for Length
            Width = 4;   // Set a default value for Width
        }

        // Override the Area method for Rektangel
        public override double Area()
        {
            return Length * Width;
        }
    }
}

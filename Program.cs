namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object references for each class and set default values
            Geometri geometri1 = new Rektangel();
            Geometri geometri2 = new Fyrkant();
            Geometri geometri3 = new Cirkel();
            Geometri geometri4 = new Parallellogram();
            Geometri geometri5 = new Ellips();

            // Calculate and display the areas of different shapes
            Console.WriteLine("Area of Rektangel: " + geometri1.Area());
            Console.WriteLine("Area of Fyrkant: " + geometri2.Area());
            Console.WriteLine("Area of Cirkel: " + geometri3.Area());
            Console.WriteLine("Area of Parallellogram: " + geometri4.Area());
            Console.WriteLine("Area of Ellips: " + geometri5.Area());
        }
    }
}
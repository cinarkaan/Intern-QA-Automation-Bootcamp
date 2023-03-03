using System;

namespace Shapes
{
    class Program
    {

        static void Main(string[] args)
        {

            // We keep integer value of points in the List generic class type of int
            List<int> coordinates = new List<int>();

            // We take input from user and then we put them on the list generic class type of int
            Console.WriteLine("Enter coordinate x of dot A : ");
            coordinates.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter coordinate y of dot A : ");
            coordinates.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter coordinate x of dot B : ");
            coordinates.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter coordinate y of dot B : ");
            coordinates.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter coordinate x of dot C : ");
            coordinates.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter coordinate y of dot C : ");
            coordinates.Add(Convert.ToInt32(Console.ReadLine()));

            // We used polmorphism so that's why in here we are doing upcasting
            Shape shape = new Triange(coordinates);
            // We are creating a variable in order to access edge of triange
            var triange = (Triange)shape;

            Console.WriteLine("Lenght of AB is : " + triange.AB + " If we round AB lenght , it will be " + Math.Round(triange.AB, 0));
            Console.WriteLine("Lenght of BC is : " + triange.BC + " If we round BC lenght , it will be " + Math.Round(triange.BC, 0));
            Console.WriteLine("Lenght of AC is : " + triange.AC + " If we round AC lenght , it will be " + Math.Round(triange.AC, 0));

            Console.Write("\n");

            // Checking type of the triange
            triange.isEquilateral();
            triange.isIsosceles();
            triange.isRight();

            Console.Write("\n");

            Console.WriteLine("Perimeter : " + shape.Perimeter);

            Console.WriteLine("Area : " + shape.Area);

            Console.Write("\n");

            Console.WriteLine("Parity numbers is range from 0 to triange perimeter : ");

            // Getting numbers until the perimeter
            shape.parity();

        }

    }

}
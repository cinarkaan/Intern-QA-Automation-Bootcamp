namespace Shapes
{
    class Triange : Shape
    {

        private double ab;
        private double bc;
        private double ac;

        public double AB
        {
            get { return ab; }
        }
        public double BC
        {
            get { return bc; }
        }
        public double AC
        {
            get { return ac; }
        }

        public Triange(List<int> coordinates)
        {
            buildTriangle(coordinates);
            calculatePerimeter();
            calculateArea();
        }

        private void buildTriangle(List<int> coordinates)
        {
            ab = (float)Math.Sqrt(Math.Pow((coordinates.ElementAt(1) - coordinates.ElementAt(0)), 2) +
                Math.Pow((coordinates.ElementAt(3) - coordinates.ElementAt(2)), 2));
            bc = (float)Math.Sqrt(Math.Pow((coordinates.ElementAt(4) - coordinates.ElementAt(1)), 2) +
                Math.Pow((coordinates.ElementAt(5) - coordinates.ElementAt(3)), 2));
            ac = (float)Math.Sqrt(Math.Pow((coordinates.ElementAt(4) - coordinates.ElementAt(0)), 2) +
                Math.Pow((coordinates.ElementAt(5) - coordinates.ElementAt(2)), 2));
        }

        public Triange()
        {

        }

        protected override void calculatePerimeter()
        {
            perimeter = AB + BC + AC;
        }


        // By using heron metod , We are able to calculate area of triange
        protected override void calculateArea()
        {
            double halfOfPerimeter = perimeter / 2.0;
            area += Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - ab) * (halfOfPerimeter - bc) * (halfOfPerimeter - ac));
        }

        // If type of triangle is equilateral , difference of all edges will  has to equal -1 times of one any edge
        public void isEquilateral()
        {
            if ((AB - BC - AC) == (-1 * AB))
                Console.WriteLine("Triange is 'Equilateral");
            else
                Console.WriteLine("Triange is NOT 'Equilateral");
        }

        public void isIsosceles()
        {
            if (AB == BC || AB == AC)
                Console.WriteLine("Triange is 'Isosceles'");
            else if (BC == AC)
                Console.WriteLine("Triange is 'Isosceles'");
            else
                Console.WriteLine("Triange is NOT 'Isosceles'");
        }

        public void isRight()
        {
            double bound = Math.Pow(BC, 2) - (Math.Pow(AB, 2) + Math.Pow(AC, 2));
            if (bound <= 0.011425)
                Console.WriteLine("Triange is 'Right'");
            else
                Console.WriteLine("Triange is NOT 'Right'");
        }

    }
}
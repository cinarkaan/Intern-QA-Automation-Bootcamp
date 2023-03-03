namespace Shapes
{
    class Shape
    {
        protected double perimeter;
        protected double area;

        public double Perimeter
        {
            get { return perimeter; }
        }

        public double Area
        {
            get { return area; }
        }

        public Shape()
        {

        }

        protected virtual void calculatePerimeter()
        {

        }

        protected virtual void calculateArea()
        {

        }
        // By doing bitwise AND operation , We can indicate number whether even or odd
        // If the result is 0 , the number will be even
        // If the result is 1 , the number will be odd
        public void parity()
        {
            for (int i = 0; i < Convert.ToInt32(perimeter); i++)
                if ((i & 1) == 0)
                    Console.WriteLine(i);
        }
    }
}
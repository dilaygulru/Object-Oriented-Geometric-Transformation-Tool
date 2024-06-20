namespace WinFormsApp1
{
    internal class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }
        private (double R, double Theta) PolarCoordinates;

        public Point2D()
        {
            // Default constructor initializes coordinates to random values and calculates polar coordinates
            Random random = new Random();
            X = random.NextDouble() * 100;
            Y = random.NextDouble() * 100;
            CalculatePolarCoordinates();
        }

        public Point2D(double x, double y)
        {
            // Constructor that initializes with specific x and y values
            X = x;
            Y = y;
            CalculatePolarCoordinates();
        }

        public void CalculatePolarCoordinates()
        {
            // Convert cartesian coordinates to polar coordinates
            double r = Math.Sqrt(X * X + Y * Y);
            double theta = Math.Atan2(Y, X) * (180 / Math.PI);
            PolarCoordinates = (r, theta);
        }

        public void CalculateCartesianCoordinates()
        {
            // Convert polar coordinates back to cartesian coordinates
            X = PolarCoordinates.R * Math.Cos(PolarCoordinates.Theta * Math.PI / 180);
            Y = PolarCoordinates.R * Math.Sin(PolarCoordinates.Theta * Math.PI / 180);
        }

        public void PrintCoordinates()
        {
            Console.WriteLine($"Cartesian Coordinates: X={X}, Y={Y}");
        }

        public void PrintPolarCoordinates()
        {
            Console.WriteLine($"Polar Coordinates: R={PolarCoordinates.R}, Θ={PolarCoordinates.Theta} degrees");
        }
    }
}

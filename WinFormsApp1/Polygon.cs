namespace WinFormsApp1
{
    internal class Polygon
    {
        public Point2D Center { get; set; }
        public double Length { get; set; }
        public int NumberOfEdges { get; set; }
        public Point2D[] Vertices { get; set; }

        public Polygon()
        {
            // Default constructor initializes a triangle as minimum polygon
            Center = new Point2D();
            Length = 0;
            NumberOfEdges = 3;
            Vertices = new Point2D[NumberOfEdges];
            CalculateEdgeCoordinates();
        }
        public Polygon(Point2D center, double length, int numberOfEdges)
        {
            // Constructor to initialize polygon with specific center, length, and number of edges
            Center = center;
            Length = length;
            NumberOfEdges = numberOfEdges;
            Vertices = new Point2D[numberOfEdges];
            CalculateEdgeCoordinates();
        }

        public void CalculateEdgeCoordinates()
        {
            // Calculate the coordinates of vertices based on the number of edges and length
            double angleStep = 360.0 / NumberOfEdges;
            for (int i = 0; i < NumberOfEdges; i++)
            {
                double angle = Math.PI * angleStep * i / 180.0;
                Vertices[i] = new Point2D
                {
                    X = Center.X + Length * Math.Cos(angle),
                    Y = Center.Y + Length * Math.Sin(angle)
                };
            }
        }
        public void RotatePolygon(double rotationAngle)
        {
            // Rotate the polygon by a given angle around its center
            double radians = Math.PI * rotationAngle / 180.0;
            for (int i = 0; i < Vertices.Length; i++)
            {
                double relX = Vertices[i].X - Center.X;
                double relY = Vertices[i].Y - Center.Y;
                Vertices[i] = new Point2D
                {
                    X = Center.X + relX * Math.Cos(radians) - relY * Math.Sin(radians),
                    Y = Center.Y + relX * Math.Sin(radians) + relY * Math.Cos(radians)
                };
            }
        }
    }

}

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Polygon polygon;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "4";
            textBox4.Text = "5";
            textBox5.Text = "30";

            //Create a new center point and polygon from default textbox values
            Point2D center = new Point2D(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            double length = double.Parse(textBox3.Text);
            int numberOfEdges = int.Parse(textBox4.Text);

            polygon = new Polygon(center, length, numberOfEdges);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Randomize all text box values within specified ranges
            Random random = new Random();
            textBox1.Text = random.Next(0, 4).ToString();
            textBox2.Text = random.Next(0, 4).ToString();
            textBox3.Text = random.Next(3, 10).ToString();
            textBox4.Text = random.Next(3, 11).ToString();
            textBox5.Text = random.Next(0, 360).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double centerX = double.Parse(textBox1.Text);
            double centerY = double.Parse(textBox2.Text);
            double length = double.Parse(textBox3.Text);
            int numberOfEdges = int.Parse(textBox4.Text);

            Point2D center = new Point2D(centerX, centerY);
            polygon = new Polygon(center, length, numberOfEdges);
            polygon.CalculateEdgeCoordinates();

            listBox1.Items.Clear();
            foreach (Point2D vertex in polygon.Vertices)
            {
                listBox1.Items.Add($"({vertex.X}, {vertex.Y})");
            }

            DrawPolygon(polygon);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Rotate the polygon and redraw if a polygon is present
            if (polygon == null || pictureBox1.Image == null)
            {
                MessageBox.Show("Draw a polygon first!");
                return;
            }

            double rotationAngle = double.Parse(textBox5.Text);
            polygon.RotatePolygon(rotationAngle);
            DrawPolygon(polygon);

        }
        private void DrawPolygon(Polygon polygon)
        {
            // Function to draw the polygon on a pictureBox
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {

                float scale = 22;
                PointF[] points = polygon.Vertices.Select(v => new PointF(
                    pictureBox1.Width / 2 + (float)(v.X - polygon.Center.X) * scale,
                    pictureBox1.Height / 2 + (float)(v.Y - polygon.Center.Y) * scale
                )).ToArray();

                if (points.Length > 1)
                {
                    g.DrawPolygon(Pens.Black, points);
                }
            }
            pictureBox1.Image = bitmap;
        }
    }
}

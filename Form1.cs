namespace oop3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)


        {
            
            
         string[] shapes = { "Circle", "Triangle", "Rectangle" };
     

            for (int i = 0; i < shapes.Length; i++){
                    comboBox1.Items.Add(shapes[i]);
            }

            resultBox.ReadOnly = true;

               
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        class Shape
        {
            public double Length
            { get; protected set; }
            public double Height
            { get; protected set; }
            public double Width
            { get; protected set; }
            public double BAse
            { get; protected set; }
            public double Radius
            { get; protected set; }
            public Shape(double length = 0, double height = 0, double width = 0, double baseValue = 0, double radius = 0)
            {
                Length = length;
                Height = height;
                Width = width;
                BAse = baseValue;
                Radius = radius;
            }
            // For Rectangle
            public double CalculateArea(double length, double width)
            {
                return length * width;
            }

            // For Circle
            public double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }

            // For Triangle
            public double CalculateArea(int Base, int height)
            {
                return 0.5 * Base * height;
            }




        }

        private void Compute_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a shape first.");
                return;
            }

            double area = 0;
            string selectedShape = comboBox1.SelectedItem.ToString();

           

            if (selectedShape == "Circle")
            {
                Shape circle = new Shape(radius: Convert.ToDouble(Radius_TextBox.Text));
                area = circle.CalculateArea();
                listBox1.Items.Add($"The area of the {selectedShape} is: {area:f2}");
                resultBox.Text = string.Empty;
                resultBox.Text = Convert.ToString($"{area:f2}");
            }
            if (selectedShape == "Triangle")
            {
                Shape triangle = new Shape();
                area = triangle.CalculateArea(Base: Convert.ToInt32(Base_TextBox.Text), height: Convert.ToInt32(Height_TextBox.Text));
                listBox1.Items.Add($"The area of the {selectedShape} is: {area:f2}");
                resultBox.Text = string.Empty;
                resultBox.Text = Convert.ToString($"{area:f2}");
            }
            if (selectedShape == "Rectangle")
            {
                Shape rectangle = new Shape(length: Convert.ToDouble(Length_TextBox.Text), width: Convert.ToDouble(Width_TextBox.Text));
                area = rectangle.CalculateArea(rectangle.Length, rectangle.Width);
                listBox1.Items.Add($"The area of the {selectedShape} is: {area:f2}");
                resultBox.Text = string.Empty;
                resultBox.Text = Convert.ToString($"{area:f2}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }

        }
    }
}
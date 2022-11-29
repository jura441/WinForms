

namespace DZ_Week_3_bus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      List<Route> routes = new List<Route>();

        private void Form1_Load(object sender, EventArgs e)
        {
            routes.Add(new Route(1, "40местный", "Ростов", new DateTime(2022, 11, 29), new TimeSpan(9, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(10, 45, 0)));
            routes.Add(new Route(2, "20местный", "Ростов", new DateTime(2022, 11, 29), new TimeSpan(9, 30, 0), new DateTime(2022, 11, 29), new TimeSpan(11, 00, 0)));
            routes.Add(new Route(3, "40местный", "Ростов", new DateTime(2022, 11, 29), new TimeSpan(10, 0, 0), new DateTime(2022, 11, 29), new TimeSpan(11, 30, 0)));
            routes.Add(new Route(4, "40местный", "Ростов", new DateTime(2022, 11, 29), new TimeSpan(10, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(11, 45, 0)));
            routes.Add(new Route(5, "20местный", "Ростов", new DateTime(2022, 11, 29), new TimeSpan(10, 45, 0), new DateTime(2022, 11, 29), new TimeSpan(12, 15, 0)));
            routes.Add(new Route(6, "20местный", "Ростов", new DateTime(2022, 11, 29), new TimeSpan(11, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(12, 45, 0)));
            routes.Add(new Route(7, "20местный", "Ростов", new DateTime(2022, 11, 29), new TimeSpan(13, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(14, 45, 0)));
            routes.Add(new Route(8, "40местный", "Ростов", new DateTime(2022, 11, 29), new TimeSpan(15, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(16, 45, 0)));
            routes.Add(new Route(9, "40местный", "Ростов", new DateTime(2022, 11, 29), new TimeSpan(17, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(18, 45, 0)));
            routes.Add(new Route(10, "40местный", "Ростов", new DateTime(2022, 11, 30), new TimeSpan(9, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(10, 45, 0)));
            routes.Add(new Route(11, "20местный", "Ростов", new DateTime(2022, 11, 30), new TimeSpan(10, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(11, 45, 0)));
            for (int i = 0; i < routes.Count; i++)
            {
                listBox1.Items.Add(routes[i]);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
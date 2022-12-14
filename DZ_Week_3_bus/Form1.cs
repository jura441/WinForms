

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
            routes.Add(new Route(1, "40???????", "??????", new DateTime(2022, 11, 29), new TimeSpan(9, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(10, 45, 0)));
            routes.Add(new Route(2, "20???????", "??????", new DateTime(2022, 11, 29), new TimeSpan(9, 30, 0), new DateTime(2022, 11, 29), new TimeSpan(11, 00, 0)));
            routes.Add(new Route(3, "40???????", "??????", new DateTime(2022, 11, 29), new TimeSpan(10, 0, 0), new DateTime(2022, 11, 29), new TimeSpan(11, 30, 0)));
            routes.Add(new Route(4, "40???????", "??????", new DateTime(2022, 11, 29), new TimeSpan(10, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(11, 45, 0)));
            routes.Add(new Route(5, "20???????", "??????", new DateTime(2022, 11, 29), new TimeSpan(10, 45, 0), new DateTime(2022, 11, 29), new TimeSpan(12, 15, 0)));
            routes.Add(new Route(6, "20???????", "??????", new DateTime(2022, 11, 29), new TimeSpan(11, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(12, 45, 0)));
            routes.Add(new Route(7, "20???????", "??????", new DateTime(2022, 11, 29), new TimeSpan(13, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(14, 45, 0)));
            routes.Add(new Route(8, "40???????", "??????", new DateTime(2022, 11, 29), new TimeSpan(15, 15, 0), new DateTime(2022, 12, 15), new TimeSpan(16, 45, 0)));
            routes.Add(new Route(9, "40???????", "??????", new DateTime(2022, 11, 29), new TimeSpan(17, 15, 0), new DateTime(2022, 12, 16), new TimeSpan(18, 45, 0)));
            routes.Add(new Route(10, "40???????", "??????", new DateTime(2022, 11, 30), new TimeSpan(9, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(10, 45, 0)));
            routes.Add(new Route(11, "20???????", "??????", new DateTime(2022, 11, 30), new TimeSpan(10, 15, 0), new DateTime(2022, 11, 29), new TimeSpan(11, 45, 0)));
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
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_defaultRoute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < routes.Count; i++)
            {
                listBox1.Items.Add(routes[i]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DateTime dateFilter = DateTime.Now.Date;
            dateFilter = dateFilter.AddDays(1);
            dateFilter = dateFilter.AddHours(Double.Parse(tb_destHours.Text));
            dateFilter = dateFilter.AddMinutes(Double.Parse(tb_destMinutes.Text));
            dateFilter = dateFilter.AddSeconds(Double.Parse(tb_destSeconds.Text));
            foreach (Route route in routes)
            {

               if (route.getBusDestination().Trim().ToLower() == tb_destination.Text.Trim().ToLower() && route.getDateTo() <= dateFilter && route.getDateFrom() > DateTime.Now.Date)
                {
                    listBox1.Items.Add(route.ToString());
                }
            }
        }
    }

    }
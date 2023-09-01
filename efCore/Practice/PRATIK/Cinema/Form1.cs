using Cinema.Models;

namespace Cinema
{
    public partial class Form1 : Form
    {
        CinemaDbContext context;
        public Form1()
        {
            InitializeComponent();
            context = new();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new();
        }
    }
}
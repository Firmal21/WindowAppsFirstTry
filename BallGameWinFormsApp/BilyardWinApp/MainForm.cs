namespace BilyardWinApp
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            var ball = new BilyardBall(this);
            ball.Start();
        }
    }
}

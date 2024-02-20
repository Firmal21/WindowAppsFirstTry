using BallGameWinFormsApp;

namespace CatchMeGame
{
    public partial class MainForm : Form
    {
        private List<Ball> balls;
        private int ballsCount = 15;
        private int _cathBallCount;
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;
            clearButton.Enabled = false;

            balls = new List<Ball>();

            for (int i = 0; i < ballsCount; i++)
            {
                var moveBall = new RandomMoveBall(this);
                balls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            clearButton.Enabled = false;

            foreach (var ball in balls)
            {
                ball.Clear();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = false;
            clearButton.Enabled = true;

            foreach (var ball in balls)
            {
                ball.Stop();
            }
            MessageBox.Show("Вы поймали: " + _cathBallCount.ToString() + balls[0].GetString(_cathBallCount));
            _cathBallCount = 0;

        }

        private void stopButton_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(balls != null) 
            {
                var mouseX = e.X;
                var mouseY = e.Y;

                for (int i = 0; i < ballsCount; i++)
                {
                    if (balls[i].IsMovable() && balls[i].CatchBall(balls, i, mouseX, mouseY))
                    { _cathBallCount++; }
                }
            }
            cathedBallsLabel.Text = _cathBallCount.ToString();
        }
    }
}

using BallGameWinFormsApp;

namespace CatchMeGame
{
    public partial class MainForm : Form
    {
        private List<RandomMoveBall> moveBalls;
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

            moveBalls = new List<RandomMoveBall>();

            for (int i = 0; i < ballsCount; i++)
            {
                var moveBall = new RandomMoveBall(this);
                moveBalls.Add(moveBall);
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

            foreach (var ball in moveBalls)
            {
                ball.Clear();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = false;
            clearButton.Enabled = true;

            foreach (var ball in moveBalls)
            {
                ball.Stop();
            }
            MessageBox.Show("Вы поймали: " + _cathBallCount.ToString() + moveBalls[0].GetString(_cathBallCount));
            _cathBallCount = 0;

        }

        private void stopButton_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(moveBalls != null) 
            {
                var mouseX = e.X;
                var mouseY = e.Y;

                for (int i = 0; i < ballsCount; i++)
                {
                    if (moveBalls[i].IsMovable() && moveBalls[i].CatchBall(moveBalls, i, mouseX, mouseY))
                    { _cathBallCount++; }
                }
            }
            cathedBallsLabel.Text = _cathBallCount.ToString();
        }
    }
}

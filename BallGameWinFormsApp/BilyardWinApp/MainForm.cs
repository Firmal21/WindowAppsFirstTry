using BallsCommon;
using System.Windows.Forms;

namespace BilyardWinApp
{
    public partial class MainFrom : Form
    {
        private int _ballsCount = 2;
        List<Ball> RedBalls;
        List<Ball> BlueBalls;
        Random random = new Random();
        public MainFrom()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _ballsCount; i++) 
            {
                var ball = new BilyardBall(this);
                ball.OnHited += Ball_OnHited;
                ball.Start();
                ball.SetBallColor(Brushes.Green);
                ball.centerX = random.Next(ball.radius, this.ClientSize.Width/2 - ball.radius);
                
            }

            for (int i = 0; i < _ballsCount; i++)
            {
                var ball = new BilyardBall(this);
                ball.OnHited += Ball_OnHited;
                ball.Start();
                ball.SetBallColor(Brushes.Red);
                ball.centerX = random.Next(this.ClientSize.Width / 2 + ball.radius, this.ClientSize.Width -ball.radius );
            }
        }

        private void Ball_OnHited(object? sender, BilyardBall.HitEventArgs e)
        {
            switch (e.Side)
            {
                case BilyardBall.Side.LeftRed:
                    leftRedSideLabel.Text = (Int32.Parse(leftRedSideLabel.Text) + 1).ToString(); 
                    break;
                case BilyardBall.Side.LeftGreen:
                    leftGreenSidelabel.Text = (Int32.Parse(leftGreenSidelabel.Text) + 1).ToString();
                    break;

                case BilyardBall.Side.RightRed:
                    rightSideLabel.Text = (Int32.Parse(rightSideLabel.Text) + 1).ToString(); 
                    break;
                case BilyardBall.Side.RightGreen:
                    rightGreenSidelabel.Text = (Int32.Parse(rightGreenSidelabel.Text) + 1).ToString();
                    break;

                case BilyardBall.Side.TopRed:
                    topSideLabel.Text = (Int32.Parse(topSideLabel.Text) + 1).ToString(); 
                    break;
                case BilyardBall.Side.TopGreen:
                    topGreenSidelabel.Text = (Int32.Parse(topGreenSidelabel.Text) + 1).ToString();
                    break;

                case BilyardBall.Side.DownRed:
                    downSideLabel.Text = (Int32.Parse(downSideLabel.Text) + 1).ToString(); 
                    break;
                case BilyardBall.Side.DownGreen:
                    downGreenSidelabel.Text = (Int32.Parse(downGreenSidelabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}

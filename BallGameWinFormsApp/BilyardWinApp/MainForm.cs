using BallsCommon;

namespace BilyardWinApp
{
    public partial class MainFrom : Form
    {
        private int _ballsCount = 8;
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
            }
        }

        private void Ball_OnHited(object? sender, BilyardBall.HitEventArgs e)
        {
            switch (e.Side)
            {
                case BilyardBall.Side.Left:
                    leftSideLabel.Text = (Int32.Parse(leftSideLabel.Text) + 1).ToString(); 
                    break;
                case BilyardBall.Side.Right:
                    rightSideLabel.Text = (Int32.Parse(rightSideLabel.Text) + 1).ToString(); 
                    break;
                case BilyardBall.Side.Top:
                    topSideLabel.Text = (Int32.Parse(topSideLabel.Text) + 1).ToString(); 
                    break;
                case BilyardBall.Side.Down:
                    downSideLabel.Text = (Int32.Parse(downSideLabel.Text) + 1).ToString(); 
                    break;
            }
        }
    }
}

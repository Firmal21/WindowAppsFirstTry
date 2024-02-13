using System.Numerics;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AimTrainer
{
    public partial class MainForm : Form
    {
        List<BallMovment> Balls;
        public int BallsCount = 10;
        public int CatchBallsCount;

        public MainForm()
        {
            InitializeComponent();
        }


        private void CreateBallsButton_Click(object sender, EventArgs e)
        {
            Balls = new List<BallMovment>();

            for (int i = 0; i < BallsCount; i++)
            {
                var moveBall = new BallMovment(this);
                Balls.Add(moveBall);
                moveBall.Start();
            }
        }
       

        private void ClearGameArea()
        {
            var graphics = this.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            graphics.FillRectangle(brush, rectangle);
        }

        private void MainForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            var mouseX = e.X;
            var mouseY = e.Y;

            for (int i = 0; i < BallsCount; i++)
            {
                Balls[i].CatchBall(Balls, i, mouseX, mouseY);
                
            }
            CathedBallsCountLabel.Text = CatchBallsCount.ToString();
        }

        private void StopButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Вы поймали: " + CatchBallsCount.ToString() + GetString(CatchBallsCount));
            
            CatchBallsCount = 0;

            for (int i = 0; i < BallsCount; i++)
            {
                Balls[i].Stop();
            }
            Application.Restart();
                //ClearGameArea();
        }

        private string GetString(int catchBallsCount)
        {
            if (catchBallsCount % 100 >= 11 && catchBallsCount % 100 <= 19)
            {
                return "шаров";
            }
            else
            {
                var i = catchBallsCount % 10;
                switch (i)
                {
                    case (1):
                        return "шар";

                    case (2):
                    case (3):
                    case (4):
                        return "шара";
                    default:
                        return "шаров";
                }
            }
        }
    }
}

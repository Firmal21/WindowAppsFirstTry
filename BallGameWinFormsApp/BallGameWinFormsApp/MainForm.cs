using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGameWinFormsApp
{
    public partial class MainForm : Form
    {
        RandomSizeAndPointBall moveBall;
        PointBall pointBall;
        List<MoveBall> moveBalls;
        int ballsCount = 6;
        public int CatchBallsCount;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ball = new Ball(this);
            ball.Show();
        }

        private void createRandomBallButton_Click(object sender, EventArgs e)
        {
            moveBall = new RandomSizeAndPointBall(this);
            moveBall.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void moveBallButton_Click(object sender, EventArgs e)
        {

            pointBall.Move();
        }
        private void moveButton_Click(object sender, EventArgs e)
        {

            moveBall.Move();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void manyBallsButton_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();

            for (int i = 0; i < ballsCount; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall); 
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

        private void stopButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i  < ballsCount; i ++)
            {
                moveBalls[i].Stop();
                moveBalls[i].CalculationStoppedBalls(moveBalls, i);
            }

            MessageBox.Show(CatchBallsCount.ToString());
            CatchBallsCount = 0;
            ClearGameArea();


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            ////for (int i = 0; i <= 10; i++)
            ////{
            ////    moveBalls[i].Move();
            ////}

        }

        private void manyBallsButton_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall); 
                moveBall.Start();
            }
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i  < 10; i ++)
            {
                moveBalls[i].Stop();
            }
            
        }
    }
}

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
        //RandomSizeAndPointBall moveBall;
        //PointBall pointBall;
        List<MoveBall> moveBalls;
        int ballsCount = 6;
        public int CatchBallsCount;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
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

        private void stopButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i  < ballsCount; i ++)
            {
                moveBalls[i].Stop();
                moveBalls[i].CalculationStoppedBalls(moveBalls, i);
            }

            MessageBox.Show("Вы поймали: " + CatchBallsCount.ToString() + "шариков");
            CatchBallsCount = 0;
            ClearGameArea();
        }

        private void ClearGameArea()
        {
            var graphics = this.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            graphics.FillRectangle(brush, rectangle);
        }


        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var mouseX = e.X;
            var mouseY = e.Y;
        }

    }
}

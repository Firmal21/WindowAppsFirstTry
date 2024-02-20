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
        List<RandomMoveBall> moveBalls;
        int ballsCount = 6;
        public int CatchBallsCount;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            manyBallsButton.Enabled = true;
            stopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void manyBallsButton_Click(object sender, EventArgs e)
        {
            moveBalls = new List<RandomMoveBall>();

            manyBallsButton.Enabled = false;
            stopButton.Enabled = true;
            clearButton.Enabled = false;

            for (int i = 0; i < ballsCount; i++)
            {
                var moveBall = new RandomMoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            manyBallsButton.Enabled = false;
            stopButton.Enabled = false;
            clearButton.Enabled = true;

            for (int i = 0; i < ballsCount; i++)
            {
                moveBalls[i].Stop();
                if(moveBalls[i].CalculationStoppedBalls(moveBalls, i))
                {
                    CatchBallsCount++;
                }
                
            }

            MessageBox.Show("Вы поймали: " + CatchBallsCount.ToString() + moveBalls[0].GetString(CatchBallsCount));
            CatchBallsCount = 0;         
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var mouseX = e.X;
            var mouseY = e.Y;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            manyBallsButton.Enabled = true;
            stopButton.Enabled = false;
            clearButton.Enabled = false;

            foreach (var ball in moveBalls)
            {
                ball.Clear();
            }
        }
    }
}

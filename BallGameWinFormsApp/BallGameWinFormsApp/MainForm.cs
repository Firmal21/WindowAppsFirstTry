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
        RandomSizeAndPointBall randomSizeAndPointBall;
        public MainForm()
        {
            InitializeComponent();
        }

        private void createRandomBallButton_Click(object sender, EventArgs e)
        {
            randomSizeAndPointBall = new RandomSizeAndPointBall(this);
            randomSizeAndPointBall.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void moveBallButton_Click(object sender, EventArgs e)
        {
            randomSizeAndPointBall.Go();
            
        }
    }
}

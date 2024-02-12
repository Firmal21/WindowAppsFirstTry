using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGameWinFormsApp
{
    public class Ball
    {
        private MainForm form;

        protected int x = 150;
        protected int y = 150;
        protected Brush brush;
        protected int size = 70;

        Random random = new Random();

        public Ball(MainForm form)
        {
            this.form = form;
            size = random.Next(10, 80);
            
        }
        public void Show()
        {
            var graphics = form.CreateGraphics();
            brush = Brushes.Aqua;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void ColorBall(int x,int y,int size, Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        private void Go() 
        {
            x += random.Next(-20, +20);
            y += random.Next(-20, +20);
            Show();
        }

        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
       
        public void CalculationStoppedBalls(List<MoveBall> moveBalls, int i)
        {
            
            List<MoveBall> balls = moveBalls;
            
            if (form.ClientSize.Width >= balls[i].x + balls[i].size &&
                    form.ClientSize.Height >= balls[i].y + balls[i].size &&
                    balls[i].x > 0 && balls[i].y > 0)
                {
                    this.form.CatchBallsCount++;
                    balls[i].brush = Brushes.Green;
                    ColorBall(balls[i].x, balls[i].y, balls[i].size, balls[i].brush);
                }
            else
            {
                balls[i].brush = Brushes.Red;
                ColorBall(balls[i].x, balls[i].y, balls[i].size, balls[i].brush);
            }
            
            
        }
      
    }

}

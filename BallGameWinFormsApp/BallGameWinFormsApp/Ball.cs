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
        private Form form;
        public int CatchBallsCount;
        protected int centerX;
        protected int centerY;
        protected int vX;
        protected int vY;
        protected Brush brush;
        protected int radius;

        Random random = new Random();

        public Ball(Form form) 
        {
            this.form = form;
            radius = random.Next(25, 50);
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());

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

        public void Show()
        {
            brush = Brushes.Aqua;
            Draw(brush);
        }

        private void Go() 
        {
            centerX += vX; //random.Next(-20, 20);
            centerY += vY;
            Show();
        }

        public void Clear()
        {
             brush = new SolidBrush(form.BackColor);
            Draw(brush);   
        }

        private void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }

        public bool OnForm()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }

        public bool CalculationStoppedBalls(List<RandomMoveBall> moveBalls, int i)
        {
            
            List<RandomMoveBall> balls = moveBalls;
            
            if (OnForm())
            {

                balls[i].brush = Brushes.Green;
                Draw(balls[i].brush);
                return true;
            }
            else
            {
                balls[i].brush = Brushes.Red;
                Draw(balls[i].brush);
                return false;
            } 
        }

        public bool CatchBall(List<RandomMoveBall> Balls, int i, int mouseX, int mouseY)
        {
            var dx = mouseX - centerX;
            var dy = mouseY - centerY;

            if (dx * dx + dy * dy <= radius * radius && OnForm())
            {

                Balls[i].Stop();
                Balls[i].brush = Brushes.Green;
                Draw(Balls[i].brush);
                return true;
            }
            return false;

            //var x0 = Balls[i].centerX + Balls[i].radius / 2;
            //var y0 = Balls[i].centerY + Balls[i].radius / 2;

            //if (OnForm() && Math.Pow(mouseX - x0, 2) + Math.Pow(mouseY - y0, 2) <= Math.Pow(Balls[i].radius, 2))
            //{

            //    Balls[i].Stop();
            //    Balls[i].brush = Brushes.Green;
            //    Draw(Balls[i].brush);
            //    return true;
            //}
            //return false;
        }

        public int LeftSide()
        {
            return radius;
        }

        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public string GetString(int catchBallsCount)
        {
            if (catchBallsCount % 100 >= 11 && catchBallsCount % 100 <= 19)
            {
                return " шаров";
            }
            else
            {
                var i = catchBallsCount % 10;
                switch (i)
                {
                    case (1):
                        return " шар";

                    case (2):
                    case (3):
                    case (4):
                        return " шара";
                    default:
                        return " шаров";
                }
            }
        }

        
    }

}

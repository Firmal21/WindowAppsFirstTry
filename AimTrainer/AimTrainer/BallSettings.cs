

namespace AimTrainer
{
    internal class BallSettings
    {
        private MainForm form;

        protected int x;
        protected int y;
        protected Brush brush;
        protected int size;

        Random random = new Random();

        public BallSettings(MainForm form)
        {
            this.form = form;
            size = random.Next(10, 80);
            x = random.Next(0, form.ClientSize.Width);
            y = random.Next(10, form.ClientSize.Height);

        }
        public void Show()
        {
            var graphics = form.CreateGraphics();
            brush = Brushes.Aqua;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void ColorBall(int x, int y, int size, Brush brush)
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

        public void CatchBall(List<BallMovment> Balls, int i, int mouseX, int mouseY)
        {

            var x0 = Balls[i].x + Balls[i].size / 2;
            var y0 = Balls[i].y + Balls[i].size / 2;

            if (Math.Pow(mouseX-x0,2) + Math.Pow(mouseY - y0, 2) <= Math.Pow(Balls[i].size/2, 2))
            {
                form.CatchBallsCount++;
                Balls[i].Stop();
                
                Balls[i].brush = Brushes.Green;
                ColorBall(Balls[i].x, Balls[i].y, Balls[i].size, Balls[i].brush);
            }





            //List<BallMovment> balls = moveBalls;

            //if (form.ClientSize.Width >= moveBalls[i].x + moveBalls[i].size &&
            //        form.ClientSize.Height >= moveBalls[i].y + moveBalls[i].size &&
            //        moveBalls[i].x > 0 && moveBalls[i].y > 0)
            //{
            //    this.form.CatchBallsCount++;
            //    balls[i].brush = Brushes.Green;
            //    ColorBall(balls[i].x, balls[i].y, balls[i].size, balls[i].brush);
            //}
            //else
            //{
            //    balls[i].brush = Brushes.Red;
            //    ColorBall(balls[i].x, balls[i].y, balls[i].size, balls[i].brush);
            //}


        }

    }
}

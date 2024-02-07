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
        private int vx = 1;
        private int vy = 1;
        protected int x = 150;
        protected int y = 150;
        

        protected int size = 70;
        public Ball(MainForm form)
        {
            this.form = form;
        }
        public void Show ()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
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
            x += vx;
            y += vy;
            Show();
        }

        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

      
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace BallGameWinFormsApp
{
    public class MoveBall: RandomPointBall
    {
        private Timer _timer;
        public MoveBall(MainForm form): base(form)
        {
            _timer = new Timer();
            _timer.Interval = 15;
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public void Start() { _timer.Start();}
        public void Stop() { _timer.Stop();}
    }
}

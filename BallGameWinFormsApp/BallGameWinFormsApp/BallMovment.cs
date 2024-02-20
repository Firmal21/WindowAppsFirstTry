using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace BallGameWinFormsApp
{
    public class BallMovment: Ball
    {
        private Timer _timer;
        public BallMovment(Form form): base(form)
        {
            
        }

        
    }
}

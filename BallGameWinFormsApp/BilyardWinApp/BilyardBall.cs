using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BallsCommon;

namespace BilyardWinApp
{
    internal partial class BilyardBall : RandomMoveBall
    {

        public event EventHandler<HitEventArgs> OnHited;
        public BilyardBall(Form form) : base(form)
        {
        }
        public void SetBallCollor()
        {
            

        }

        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide() && brush == Brushes.Red)
            {
                vX = -vX;
                OnHited.Invoke(this, new HitEventArgs(Side.LeftRed));
            }

            if (centerX <= LeftSide() && brush == Brushes.Green)
            {
                vX = -vX;
                OnHited.Invoke(this, new HitEventArgs(Side.LeftGreen));
            }


            if (centerX >= RightSide() && brush == Brushes.Red)
            {
                vX = -vX;
                OnHited.Invoke(this, new HitEventArgs(Side.RightRed));
            }

            if (centerX >= RightSide() && brush == Brushes.Green)
            {
                vX = -vX;
                OnHited.Invoke(this, new HitEventArgs(Side.RightGreen));
            }

            if (centerY <= TopSide() && brush == Brushes.Red)
            {
                vY = -vY;
                OnHited.Invoke(this, new HitEventArgs(Side.TopRed));
            }

            if (centerY <= TopSide() && brush == Brushes.Green)
            {
                vY = -vY;
                OnHited.Invoke(this, new HitEventArgs(Side.TopGreen));
            }

            if (centerY >= DownSide() && brush == Brushes.Red)
            {
                vY = -vY;
                OnHited.Invoke(this, new HitEventArgs(Side.DownRed));
            }

            if (centerY >= DownSide() && brush == Brushes.Green)
            {
                vY = -vY;
                OnHited.Invoke(this, new HitEventArgs(Side.DownGreen));
            }
        }


    }
}







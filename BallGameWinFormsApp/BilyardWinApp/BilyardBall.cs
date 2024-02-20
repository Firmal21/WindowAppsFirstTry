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
        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                vX = -vX;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }

            if(centerX >= RightSide())
            {
                vX = -vX;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centerY <= TopSide())
            {
                vY = -vY;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }

            if(centerY >= DownSide())
            {
                vY = -vY;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }


    }
}







using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BallsCommon;

namespace BilyardWinApp
{
    internal class BilyardBall : RandomMoveBall
    {
        public BilyardBall(Form form) : base(form)
        {
        }
        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide() || centerX >= RightSide())
            {
                vX = -vX;
            }
            if (centerY <= TopSide() || centerY >= DownSide())
            {
                vY = -vY;
            }
        }


    }
}







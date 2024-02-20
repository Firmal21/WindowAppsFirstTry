using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGameWinFormsApp
{
    public class RandomMoveBall: BallMovment
    {
        protected static Random random = new Random();
        public RandomMoveBall(Form form): base(form)
        {
            //vX = random.Next(LeftSide(), RightSide()); 
            //vY = random.Next(TopSide(), DownSide());
            vX = random.Next(-5, 5);
            vY = random.Next(-2,2);
        }
    }
}

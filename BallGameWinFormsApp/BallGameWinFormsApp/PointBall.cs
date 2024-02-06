namespace BallGameWinFormsApp
{
    public class PointBall:Ball
    {
        static Random random = new Random();
        public PointBall(MainForm form, int x, int y): base(form) 
        {
            this.x = x-35;
            this.y = y-35;
        }
    }

}

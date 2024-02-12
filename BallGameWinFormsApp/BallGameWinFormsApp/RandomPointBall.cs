namespace BallGameWinFormsApp
{
    public class RandomPointBall: Ball 
    {
        protected Random random = new Random();

        public RandomPointBall(MainForm form): base(form)
        {
            x = random.Next(0,form.ClientSize.Width);
            y = random.Next(0, form.ClientSize.Height);
        }
    }

}

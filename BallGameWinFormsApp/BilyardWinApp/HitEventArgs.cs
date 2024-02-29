namespace BilyardWinApp
{
    internal partial class BilyardBall
    {
        public class HitEventArgs
        {
            public Side Side;
            public Color Color;
            public HitEventArgs(Side side/*, Color color*/)
            {
                Side = side;
                //Color = color;
            }
            
            
        }


    }
}







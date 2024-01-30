namespace _2048WindowsFormsApp
{
    public class User
    {
        public string Name { get; set; }
        
        public int Score { get; set; }

        public User(string name)
        {
            Name = name;
            Score = 0;
        }
    }
}

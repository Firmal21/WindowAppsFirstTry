//using System.Text;

using System;

namespace GeniyIdiotClassLibrary
{
    public class Questions
    {
        public string Text { get; set; }
        public int Answer { get; set; }
        public Questions(string text, int answer)
        {
            Text = text;
            Answer = answer;
        }
    }
}


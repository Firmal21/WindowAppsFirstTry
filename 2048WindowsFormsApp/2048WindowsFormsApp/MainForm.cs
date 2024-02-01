using System;

using System.Drawing;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int mapSize = WelcomeForm.MapSize;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        public User user;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user = new User(WelcomeForm.UserName);
            
            nameLabel.Text = ("Привет, " + user.Name + " !");

            InitMap();
            GenerateNumber();
            ShowScore();
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();

            var highscore = UserResults.GetHighScore();
            if(highscore <= score) { highscore = score; }
            highScoreLabel.Text = ("лучший результат:" + highscore);
        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];

            for(int i = 0; i<mapSize; i++)
            {
                for(int j = 0; j<mapSize;j++)
                {
                    var newLabel = CreateLable(i,j);
                    Controls.Add(newLabel);
                    labelsMap[i,j] = newLabel;
                }
            }
        }


        private void ChangeLabelColor()
        {

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    switch (labelsMap[i, j].Text)
                    {
                        case "": labelsMap[i, j].BackColor = System.Drawing.SystemColors.ButtonShadow; ; break;
                        case "2": labelsMap[i, j].BackColor = System.Drawing.Color.LightCoral;  break;
                        case "4": labelsMap[i, j].BackColor = System.Drawing.Color.RosyBrown;  break;
                        case "8": labelsMap[i, j].BackColor = System.Drawing.Color.IndianRed;  break;
                        case "16": labelsMap[i, j].BackColor = System.Drawing.Color.Brown; break;
                        case "32": labelsMap[i, j].BackColor = System.Drawing.Color.Firebrick; break;
                        case "64": labelsMap[i, j].BackColor = System.Drawing.Color.Maroon; break;
                        case "128": labelsMap[i, j].BackColor = System.Drawing.Color.LightGreen; break;
                        case "256": labelsMap[i, j].BackColor = System.Drawing.Color.LimeGreen; break;
                        case "512": labelsMap[i, j].BackColor = System.Drawing.Color.ForestGreen; break;
                        case "1024": labelsMap[i, j].BackColor = System.Drawing.Color.DarkGreen; break;
                        case "2048": labelsMap[i, j].BackColor = System.Drawing.Color.Fuchsia; break;

                    }
                }
            }
        }

        private void GenerateNumber()
        {
            // попробовать избавиться бы(детерминировать)
            while(true) 
            { 
                var randomNumberLable = random.Next(mapSize*mapSize);
                var indexRow = randomNumberLable / mapSize;
                var indexColumn = randomNumberLable % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    int chance = random.Next(0, 100) + 1;
                    if (chance >= 75)
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";  
                    }
                    if (chance <= 75)
                    {
                        labelsMap[indexRow, indexColumn].Text = "2";
                    }         
                    break;
                }

            }
        }
        
        private Label CreateLable(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = System.Drawing.SystemColors.ButtonShadow;

            label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(70, 70);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = string.Empty;
            int x = 10 + indexColumn * (76);
            int y = 70 + indexRow * (76);
            label.Location = new Point(x, y);
            return label;
        }


       


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                return;
            }

            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }

            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
            }

            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
            }

            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
            }

            GenerateNumber();
            ChangeLabelColor();
            ShowScore();
            
            if (GameOver())
            {
                if(Win())
                {
                    MessageBox.Show("Вы победили!");
                }

                if(!Win())
                {
                    MessageBox.Show("Проебал! ЛОХ!");
                }
                
                user.Score = score;
                UserResults.SaveTestResults(user);

                string restartMessage = "Хотите начать игру снова?";
                var messageResult = MessageBoxShowDialog(restartMessage);

                if (messageResult == true)
                {
                    Application.Restart();
                }

                string userResultsMessage = "Хотите увидеть предыдущие результаты?";
                var userResultsMessageResult = MessageBoxShowDialog(userResultsMessage);

                if (userResultsMessageResult == true)
                {
                    this.Hide();
                    var userResultsForm = new UserRestultsForm();
                    userResultsForm.Show();
                }

                Application.Exit();
            }
        }

        private bool GameOver()
        {

            if (Win())
            {
                return true;
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "")
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool Win()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "2048")
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void GameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RulesForm rulesForm = new RulesForm();
            rulesForm.ShowDialog();
        }

        private bool MessageBoxShowDialog(string message)
        {
            string resultsCaption = "";
            MessageBoxButtons resultsButtons = MessageBoxButtons.YesNo;
            DialogResult showResult;
            showResult = MessageBox.Show(message, resultsCaption, resultsButtons);
            if (showResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }


        //Кнопки меню
        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены что хотите перезапустить игру?";
            var messageResult = MessageBoxShowDialog(message);

            if (messageResult == true)
            {
                UserResults.SaveTestResults(user);
                Application.Restart();
            }
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены что хотите выйти из игры?";
            var messageResult = MessageBoxShowDialog(message);

            if (messageResult == true)
            {
                UserResults.SaveTestResults(user);
                Application.Exit();
            }
            
        }

        private void ShowResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserResults.SaveTestResults(user);
            this.Close();
            var userResultsForm = new UserRestultsForm();
            userResultsForm.Show();
        }

        private void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {

                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text) * 2;
                                    score += number * 2;
                                    labelsMap[i, j].Text = number.ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }

                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {

                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }

                    }
                }
            }
        }

        private void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {

                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text) * 2;
                                    score += number * 2;
                                    labelsMap[i, j].Text = number.ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }

                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {

                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }

                    }
                }
            }
        }

        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j <= mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k <= mapSize - 1; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, k].Text) * 2;
                                    score += number * 2;
                                    labelsMap[i, j].Text = number.ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }

                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j <= mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k <= mapSize - 1; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }

                    }
                }
            }
        }

        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, k].Text) * 2;
                                    score += number * 2;
                                    labelsMap[i, j].Text = number.ToString();
                                    labelsMap[i, k].Text = string.Empty;

                                }
                                break;
                            }
                        }

                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }

                    }
                }
            }
        }
    }

}

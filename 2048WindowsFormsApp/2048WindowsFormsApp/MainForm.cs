using System;

using System.Drawing;

using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private const int mapSize = 4;
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
            label.BackColor =SystemColors.ButtonShadow;
            label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(70, 70);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = string.Empty;
            int x = 10 + indexColumn * (76);
            int y = 70 + indexRow * (76);
            label.Location = new Point(x, y);
            return label;
        }


        private bool GameOver()
        {

            bool clearLabels = true;
            bool mergeChance = true;

            //Проверка остались ли свободные ячейки

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        clearLabels = true;
                        break;
                    }
                    clearLabels = false;
                }
            }
            return clearLabels;
            //Проверка на возможность соединения ячеек
            //right
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
                                    mergeChance = true;
                                    
                                }

                            }
                        }
                        break;
                    }
                }
            }
            //left
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
                                    mergeChance = true;
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
            }
            //up
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
                                    mergeChance = true;
                                    
                                }
                            }
                        }
                        break;
                    }
                }
            }
            //down
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
                                    mergeChance = true;
                                   
                                }
                                
                            }
                        }
                        break;
                    }
                }
            }

            if (clearLabels != true && mergeChance != true)
            {
                return false;
            }
            else return true;
        }
        


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right) 
            {
               for(int i=0; i < mapSize; i++)
               {
                    for(int j = mapSize-1; j >= 0; j--)
                    {
                        if (labelsMap[i,j].Text != string.Empty)
                        {
                            for(int k = j-1; k >=0; k--)
                            {
                                if (labelsMap[i,k].Text != string.Empty) 
                                {
                                    if(labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, k].Text)*2;
                                        score += number * 2;
                                        labelsMap[i,j].Text = number.ToString();
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
            
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j <= mapSize-1; j++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k <= mapSize-1; k++)
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
                            for (int k = j + 1; k <= mapSize-1; k++)
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

            if (e.KeyCode == Keys.Up)
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
        
            if (e.KeyCode == Keys.Down)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize-1; i >= 0 ; i--)
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
                    for (int i = mapSize-1; i >= 0 ; i--)
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

            GenerateNumber();
            ShowScore();

            if(!GameOver())
            {
                MessageBox.Show("Конец игры");
                user.Score = score;
                UserResults.SaveTestResults(user);

                //string restartMessage = "Хотите начать игру снова?";
                //var messageResult = MessageBoxShowDialog(restartMessage);

                //if (messageResult == true)
                //{
                //    Application.Restart();
                //}

                //string userResultsMessage = "Хотите увидеть предыдущие результаты?";
                //var userResultsMessageResult = MessageBoxShowDialog(userResultsMessage);
                
                //if (userResultsMessageResult == true)
                //{
                //    this.Hide();
                //    var userResultsForm = new UserRestultsForm();
                //    userResultsForm.Show();
                //}


            }
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

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены что хотите перезапустить игру?";
            var messageResult = MessageBoxShowDialog(message);

            if (messageResult == true)
            {
                Application.Restart();
            }
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены что хотите выйти из игры?";
            var messageResult = MessageBoxShowDialog(message);

            if (messageResult == true)
            {
                Application.Exit();
            }
            this.Close();
        }

        private void ShowResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var userResultsForm = new UserRestultsForm();
            userResultsForm.Show();
        }
    }
}

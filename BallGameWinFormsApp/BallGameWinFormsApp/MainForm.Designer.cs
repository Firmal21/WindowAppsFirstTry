namespace BallGameWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            createRandomBallButton = new Button();
            moveBallButton = new Button();
            moveButton = new Button();
            button1 = new Button();
            timer = new System.Windows.Forms.Timer(components);
            manyBallsButton = new Button();
            stopButton = new Button();
            SuspendLayout();
            // 
            // createRandomBallButton
            // 
            createRandomBallButton.Location = new Point(631, 12);
            createRandomBallButton.Name = "createRandomBallButton";
            createRandomBallButton.Size = new Size(157, 23);
            createRandomBallButton.TabIndex = 0;
            createRandomBallButton.Text = "Создать в рандомном месте";
            createRandomBallButton.UseVisualStyleBackColor = true;
            createRandomBallButton.Click += createRandomBallButton_Click;
            // 
            // moveBallButton
            // 
            moveBallButton.Location = new Point(195, 12);
            moveBallButton.Name = "moveBallButton";
            moveBallButton.Size = new Size(160, 23);
            moveBallButton.TabIndex = 1;
            moveBallButton.Text = "Двигать шар от мыши";
            moveBallButton.UseVisualStyleBackColor = true;
            moveBallButton.Click += moveBallButton_Click;
            // 
            // moveButton
            // 
            moveButton.Location = new Point(407, 12);
            moveButton.Name = "moveButton";
            moveButton.Size = new Size(175, 23);
            moveButton.TabIndex = 2;
            moveButton.Text = "Двигать рандомный";
            moveButton.UseVisualStyleBackColor = true;
            moveButton.Click += moveButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer
            // 
            timer.Interval = 15;
            timer.Tick += timer_Tick;
            // 
            // manyBallsButton
            // 
            manyBallsButton.Location = new Point(422, 64);
            manyBallsButton.Name = "manyBallsButton";
            manyBallsButton.Size = new Size(160, 23);
            manyBallsButton.TabIndex = 4;
            manyBallsButton.Text = "Много шариков";
            manyBallsButton.UseVisualStyleBackColor = true;
            manyBallsButton.Click += manyBallsButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(307, 62);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(75, 23);
            stopButton.TabIndex = 5;
            stopButton.Text = "Остановить шарики";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(stopButton);
            Controls.Add(manyBallsButton);
            Controls.Add(button1);
            Controls.Add(moveButton);
            Controls.Add(moveBallButton);
            Controls.Add(createRandomBallButton);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button createRandomBallButton;
        private Button moveBallButton;
        private Button moveButton;
        private Button button1;
        private System.Windows.Forms.Timer timer;
        private Button manyBallsButton;
        private Button stopButton;
    }
}
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
            createRandomBallButton = new Button();
            moveBallButton = new Button();
            SuspendLayout();
            // 
            // createRandomBallButton
            // 
            createRandomBallButton.Location = new Point(713, 12);
            createRandomBallButton.Name = "createRandomBallButton";
            createRandomBallButton.Size = new Size(75, 23);
            createRandomBallButton.TabIndex = 0;
            createRandomBallButton.Text = "Создать в рандомном месте";
            createRandomBallButton.UseVisualStyleBackColor = true;
            createRandomBallButton.Click += createRandomBallButton_Click;
            // 
            // moveBallButton
            // 
            moveBallButton.Location = new Point(715, 41);
            moveBallButton.Name = "moveBallButton";
            moveBallButton.Size = new Size(75, 23);
            moveBallButton.TabIndex = 1;
            moveBallButton.Text = "Двигать";
            moveBallButton.UseVisualStyleBackColor = true;
            moveBallButton.Click += moveBallButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
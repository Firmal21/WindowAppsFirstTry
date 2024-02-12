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
            timer = new System.Windows.Forms.Timer(components);
            manyBallsButton = new Button();
            stopButton = new Button();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Interval = 15;
            
            // 
            // manyBallsButton
            // 
            manyBallsButton.Location = new Point(684, 1);
            manyBallsButton.Name = "manyBallsButton";
            manyBallsButton.Size = new Size(119, 23);
            manyBallsButton.TabIndex = 4;
            manyBallsButton.Text = "Создать шарики";
            manyBallsButton.UseVisualStyleBackColor = true;
            manyBallsButton.Click += manyBallsButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(0, 1);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(115, 23);
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
            ClientSize = new Size(805, 383);
            Controls.Add(stopButton);
            Controls.Add(manyBallsButton);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            //MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Button manyBallsButton;
        private Button stopButton;
    }
}
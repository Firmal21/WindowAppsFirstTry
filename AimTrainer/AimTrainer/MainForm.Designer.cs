namespace AimTrainer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateBallsButton = new Button();
            label1 = new Label();
            label2 = new Label();
            StopButton = new Button();
            label3 = new Label();
            CathedBallsCountLabel = new Label();
            SuspendLayout();
            // 
            // CreateBallsButton
            // 
            CreateBallsButton.Location = new Point(12, 415);
            CreateBallsButton.Name = "CreateBallsButton";
            CreateBallsButton.Size = new Size(75, 23);
            CreateBallsButton.TabIndex = 0;
            CreateBallsButton.Text = "button1";
            CreateBallsButton.UseVisualStyleBackColor = true;
            CreateBallsButton.Click += CreateBallsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 0, 0);
            label1.Font = new Font("Snap ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, -2);
            label1.Name = "label1";
            label1.Size = new Size(502, 82);
            label1.TabIndex = 1;
            label1.Text = "АИМ ТРЕНЕР";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.Font = new Font("Swis721 BlkCn BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 80);
            label2.Name = "label2";
            label2.Size = new Size(349, 32);
            label2.TabIndex = 2;
            label2.Text = "ДОКАЖИ ЧТО ТЫ СИГМА";
            // 
            // StopButton
            // 
            StopButton.Location = new Point(119, 414);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(75, 23);
            StopButton.TabIndex = 3;
            StopButton.Text = "Стоп";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 423);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 4;
            label3.Text = "Количество очков: ";
            // 
            // CathedBallsCountLabel
            // 
            CathedBallsCountLabel.AutoSize = true;
            CathedBallsCountLabel.Location = new Point(409, 421);
            CathedBallsCountLabel.Name = "CathedBallsCountLabel";
            CathedBallsCountLabel.Size = new Size(13, 15);
            CathedBallsCountLabel.TabIndex = 5;
            CathedBallsCountLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(CathedBallsCountLabel);
            Controls.Add(label3);
            Controls.Add(StopButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CreateBallsButton);
            Name = "MainForm";
            Text = "Form1";
            //Load += Form1_Load;
            MouseDown += MainForm_MouseDown_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateBallsButton;
        private Label label1;
        private Label label2;
        private Button StopButton;
        private Label label3;
        private Label CathedBallsCountLabel;
    }
}

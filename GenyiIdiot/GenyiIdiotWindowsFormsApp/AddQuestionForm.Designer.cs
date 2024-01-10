namespace GenyiIdiotWindowsFormsApp
{
    partial class AddQuestionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newQuestionText = new System.Windows.Forms.TextBox();
            this.newQuestionAnswer = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(735, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите новый вопрос";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Введите ответ на этот вопрос";
            // 
            // newQuestionText
            // 
            this.newQuestionText.Location = new System.Drawing.Point(87, 76);
            this.newQuestionText.Name = "newQuestionText";
            this.newQuestionText.Size = new System.Drawing.Size(453, 20);
            this.newQuestionText.TabIndex = 16;
            // 
            // newQuestionAnswer
            // 
            this.newQuestionAnswer.Location = new System.Drawing.Point(87, 160);
            this.newQuestionAnswer.Name = "newQuestionAnswer";
            this.newQuestionAnswer.Size = new System.Drawing.Size(100, 20);
            this.newQuestionAnswer.TabIndex = 17;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.LightPink;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextButton.Location = new System.Drawing.Point(87, 201);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(172, 87);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.menuButton.FlatAppearance.BorderSize = 3;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton.ForeColor = System.Drawing.Color.Black;
            this.menuButton.Location = new System.Drawing.Point(-1, -6);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 40);
            this.menuButton.TabIndex = 19;
            this.menuButton.Text = "Меню";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.newQuestionAnswer);
            this.Controls.Add(this.newQuestionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            this.Load += new System.EventHandler(this.AddQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newQuestionText;
        private System.Windows.Forms.TextBox newQuestionAnswer;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button menuButton;
    }
}
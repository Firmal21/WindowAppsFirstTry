namespace GenyiIdiotWindowsFormsApp
{
    partial class DeleteQuestionsForm
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
            this.menuButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Label();
            this.questionsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteQuestionNumber = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.menuButton.Location = new System.Drawing.Point(0, 1);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 40);
            this.menuButton.TabIndex = 16;
            this.menuButton.Text = "Меню";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(741, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 25);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // questionsTextBox
            // 
            this.questionsTextBox.BackColor = System.Drawing.Color.LightPink;
            this.questionsTextBox.Location = new System.Drawing.Point(81, 1);
            this.questionsTextBox.Multiline = true;
            this.questionsTextBox.Name = "questionsTextBox";
            this.questionsTextBox.ReadOnly = true;
            this.questionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.questionsTextBox.Size = new System.Drawing.Size(336, 436);
            this.questionsTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Введите номер удаляемого вопроса:";
            // 
            // deleteQuestionNumber
            // 
            this.deleteQuestionNumber.Location = new System.Drawing.Point(446, 81);
            this.deleteQuestionNumber.Name = "deleteQuestionNumber";
            this.deleteQuestionNumber.Size = new System.Drawing.Size(100, 20);
            this.deleteQuestionNumber.TabIndex = 20;
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
            this.nextButton.Location = new System.Drawing.Point(437, 132);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(172, 87);
            this.nextButton.TabIndex = 21;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // DeleteQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.deleteQuestionNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionsTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.menuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteQuestionsForm";
            this.Text = "DeleteQuestionsForm";
            this.Load += new System.EventHandler(this.DeleteQuestionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TextBox questionsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteQuestionNumber;
        private System.Windows.Forms.Button nextButton;
    }
}
namespace GenyiIdiotWindowsFormsApp
{
    partial class NameForm
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(119, 136);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.userNameTextBox.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(102, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(199, 25);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "ЗДРАВСТВУЙТЕ!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пожалуйста, введите свое имя:";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(366, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 25);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.nextButton.Location = new System.Drawing.Point(119, 173);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(172, 87);
            this.nextButton.TabIndex = 10;
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
            this.menuButton.Location = new System.Drawing.Point(1, 4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 40);
            this.menuButton.TabIndex = 12;
            this.menuButton.Text = "Меню";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(405, 264);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NameForm";
            this.Text = "NameForm";
            this.Load += new System.EventHandler(this.NameForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NameForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button menuButton;
    }
}
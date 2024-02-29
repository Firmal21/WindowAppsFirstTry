namespace BilyardWinApp
{
    partial class MainFrom
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
            leftRedSideLabel = new Label();
            rightSideLabel = new Label();
            topSideLabel = new Label();
            downSideLabel = new Label();
            leftGreenSidelabel = new Label();
            topGreenSidelabel = new Label();
            downGreenSidelabel = new Label();
            rightGreenSidelabel = new Label();
            SuspendLayout();
            // 
            // leftRedSideLabel
            // 
            leftRedSideLabel.AutoSize = true;
            leftRedSideLabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftRedSideLabel.ForeColor = Color.Red;
            leftRedSideLabel.Location = new Point(12, 193);
            leftRedSideLabel.Name = "leftRedSideLabel";
            leftRedSideLabel.Size = new Size(18, 20);
            leftRedSideLabel.TabIndex = 0;
            leftRedSideLabel.Text = "0";
            // 
            // rightSideLabel
            // 
            rightSideLabel.AutoSize = true;
            rightSideLabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rightSideLabel.ForeColor = Color.Red;
            rightSideLabel.Location = new Point(734, 193);
            rightSideLabel.Name = "rightSideLabel";
            rightSideLabel.Size = new Size(18, 20);
            rightSideLabel.TabIndex = 1;
            rightSideLabel.Text = "0";
            // 
            // topSideLabel
            // 
            topSideLabel.AutoSize = true;
            topSideLabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            topSideLabel.ForeColor = Color.Red;
            topSideLabel.Location = new Point(406, 9);
            topSideLabel.Name = "topSideLabel";
            topSideLabel.Size = new Size(18, 20);
            topSideLabel.TabIndex = 2;
            topSideLabel.Text = "0";
            // 
            // downSideLabel
            // 
            downSideLabel.AutoSize = true;
            downSideLabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            downSideLabel.ForeColor = Color.Red;
            downSideLabel.Location = new Point(430, 421);
            downSideLabel.Name = "downSideLabel";
            downSideLabel.Size = new Size(18, 20);
            downSideLabel.TabIndex = 3;
            downSideLabel.Text = "0";
            // 
            // leftGreenSidelabel
            // 
            leftGreenSidelabel.AutoSize = true;
            leftGreenSidelabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftGreenSidelabel.ForeColor = Color.Green;
            leftGreenSidelabel.Location = new Point(12, 237);
            leftGreenSidelabel.Name = "leftGreenSidelabel";
            leftGreenSidelabel.Size = new Size(18, 20);
            leftGreenSidelabel.TabIndex = 4;
            leftGreenSidelabel.Text = "0";
            // 
            // topGreenSidelabel
            // 
            topGreenSidelabel.AutoSize = true;
            topGreenSidelabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            topGreenSidelabel.ForeColor = Color.Green;
            topGreenSidelabel.Location = new Point(430, 9);
            topGreenSidelabel.Name = "topGreenSidelabel";
            topGreenSidelabel.Size = new Size(18, 20);
            topGreenSidelabel.TabIndex = 5;
            topGreenSidelabel.Text = "0";
            // 
            // downGreenSidelabel
            // 
            downGreenSidelabel.AutoSize = true;
            downGreenSidelabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            downGreenSidelabel.ForeColor = Color.Green;
            downGreenSidelabel.Location = new Point(454, 421);
            downGreenSidelabel.Name = "downGreenSidelabel";
            downGreenSidelabel.Size = new Size(18, 20);
            downGreenSidelabel.TabIndex = 6;
            downGreenSidelabel.Text = "0";
            // 
            // rightGreenSidelabel
            // 
            rightGreenSidelabel.AutoSize = true;
            rightGreenSidelabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rightGreenSidelabel.ForeColor = Color.Green;
            rightGreenSidelabel.Location = new Point(734, 223);
            rightGreenSidelabel.Name = "rightGreenSidelabel";
            rightGreenSidelabel.Size = new Size(18, 20);
            rightGreenSidelabel.TabIndex = 7;
            rightGreenSidelabel.Text = "0";
            // 
            // MainFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rightGreenSidelabel);
            Controls.Add(downGreenSidelabel);
            Controls.Add(topGreenSidelabel);
            Controls.Add(leftGreenSidelabel);
            Controls.Add(downSideLabel);
            Controls.Add(topSideLabel);
            Controls.Add(rightSideLabel);
            Controls.Add(leftRedSideLabel);
            Name = "MainFrom";
            Text = "Form1";
            Load += MainFrom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftRedSideLabel;
        private Label rightSideLabel;
        private Label topSideLabel;
        private Label downSideLabel;
        private Label leftGreenSidelabel;
        private Label topGreenSidelabel;
        private Label downGreenSidelabel;
        private Label rightGreenSidelabel;
    }
}

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
            leftSideLabel = new Label();
            rightSideLabel = new Label();
            topSideLabel = new Label();
            downSideLabel = new Label();
            SuspendLayout();
            // 
            // leftSideLabel
            // 
            leftSideLabel.AutoSize = true;
            leftSideLabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftSideLabel.Location = new Point(12, 193);
            leftSideLabel.Name = "leftSideLabel";
            leftSideLabel.Size = new Size(18, 20);
            leftSideLabel.TabIndex = 0;
            leftSideLabel.Text = "0";
            // 
            // rightSideLabel
            // 
            rightSideLabel.AutoSize = true;
            rightSideLabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
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
            downSideLabel.Location = new Point(430, 421);
            downSideLabel.Name = "downSideLabel";
            downSideLabel.Size = new Size(18, 20);
            downSideLabel.TabIndex = 3;
            downSideLabel.Text = "0";
            // 
            // MainFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(downSideLabel);
            Controls.Add(topSideLabel);
            Controls.Add(rightSideLabel);
            Controls.Add(leftSideLabel);
            Name = "MainFrom";
            Text = "Form1";
            Load += MainFrom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftSideLabel;
        private Label rightSideLabel;
        private Label topSideLabel;
        private Label downSideLabel;
    }
}

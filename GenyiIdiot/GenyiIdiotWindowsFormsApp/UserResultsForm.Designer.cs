namespace GenyiIdiotWindowsFormsApp
{
    partial class UserResultsForm
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
            this.menuButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightAnswersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(761, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.menuButton.Location = new System.Drawing.Point(354, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 40);
            this.menuButton.TabIndex = 12;
            this.menuButton.Text = "Меню";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
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
            this.nextButton.Location = new System.Drawing.Point(354, 48);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(172, 87);
            this.nextButton.TabIndex = 13;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.RightAnswersColumn,
            this.DiagnosesColumn});
            this.resultsDataGridView.Location = new System.Drawing.Point(3, 7);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.Size = new System.Drawing.Size(345, 335);
            this.resultsDataGridView.TabIndex = 14;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            // 
            // RightAnswersColumn
            // 
            this.RightAnswersColumn.HeaderText = "Кол-во правильных ответов";
            this.RightAnswersColumn.Name = "RightAnswersColumn";
            // 
            // DiagnosesColumn
            // 
            this.DiagnosesColumn.HeaderText = "Диагноз";
            this.DiagnosesColumn.Name = "DiagnosesColumn";
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.label1);
            this.Name = "UserResultsForm";
            this.Text = "UserResultsForm";
            this.Load += new System.EventHandler(this.UserResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightAnswersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosesColumn;
    }
}
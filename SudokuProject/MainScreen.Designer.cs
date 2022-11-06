namespace SudokuProject
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.EasyB = new System.Windows.Forms.Button();
            this.MediumB = new System.Windows.Forms.Button();
            this.HardB = new System.Windows.Forms.Button();
            this.DifficultyL = new System.Windows.Forms.Label();
            this.LeadB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameL = new System.Windows.Forms.Label();
            this.ExitB = new System.Windows.Forms.Button();
            this.CheckYourResultsL = new System.Windows.Forms.Label();
            this.GenPuz = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.StatusL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EasyB
            // 
            this.EasyB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EasyB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EasyB.Location = new System.Drawing.Point(45, 258);
            this.EasyB.Margin = new System.Windows.Forms.Padding(4);
            this.EasyB.Name = "EasyB";
            this.EasyB.Size = new System.Drawing.Size(167, 41);
            this.EasyB.TabIndex = 0;
            this.EasyB.Text = "Easy";
            this.EasyB.UseVisualStyleBackColor = true;
            // 
            // MediumB
            // 
            this.MediumB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MediumB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MediumB.Location = new System.Drawing.Point(256, 258);
            this.MediumB.Margin = new System.Windows.Forms.Padding(4);
            this.MediumB.Name = "MediumB";
            this.MediumB.Size = new System.Drawing.Size(167, 41);
            this.MediumB.TabIndex = 1;
            this.MediumB.Text = "Medium";
            this.MediumB.UseVisualStyleBackColor = true;
            // 
            // HardB
            // 
            this.HardB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HardB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HardB.Location = new System.Drawing.Point(504, 258);
            this.HardB.Margin = new System.Windows.Forms.Padding(4);
            this.HardB.Name = "HardB";
            this.HardB.Size = new System.Drawing.Size(167, 41);
            this.HardB.TabIndex = 2;
            this.HardB.Text = "Hard";
            this.HardB.UseVisualStyleBackColor = true;
            // 
            // DifficultyL
            // 
            this.DifficultyL.AutoSize = true;
            this.DifficultyL.ForeColor = System.Drawing.SystemColors.Control;
            this.DifficultyL.Location = new System.Drawing.Point(45, 218);
            this.DifficultyL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DifficultyL.Name = "DifficultyL";
            this.DifficultyL.Size = new System.Drawing.Size(102, 27);
            this.DifficultyL.TabIndex = 3;
            this.DifficultyL.Text = "Difficultly:";
            // 
            // LeadB
            // 
            this.LeadB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LeadB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeadB.Location = new System.Drawing.Point(356, 457);
            this.LeadB.Margin = new System.Windows.Forms.Padding(4);
            this.LeadB.Name = "LeadB";
            this.LeadB.Size = new System.Drawing.Size(167, 41);
            this.LeadB.TabIndex = 4;
            this.LeadB.Text = "Score";
            this.LeadB.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 131);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameL.ForeColor = System.Drawing.SystemColors.Control;
            this.NameL.Location = new System.Drawing.Point(297, 131);
            this.NameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(209, 38);
            this.NameL.TabIndex = 6;
            this.NameL.Text = "Stukalenko Victoria CS-19-1\r\n\r\n";
            // 
            // ExitB
            // 
            this.ExitB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitB.Location = new System.Drawing.Point(255, 533);
            this.ExitB.Margin = new System.Windows.Forms.Padding(4);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(167, 41);
            this.ExitB.TabIndex = 7;
            this.ExitB.Text = "Exit";
            this.ExitB.UseVisualStyleBackColor = true;
            // 
            // CheckYourResultsL
            // 
            this.CheckYourResultsL.AutoSize = true;
            this.CheckYourResultsL.ForeColor = System.Drawing.SystemColors.Control;
            this.CheckYourResultsL.Location = new System.Drawing.Point(182, 464);
            this.CheckYourResultsL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckYourResultsL.Name = "CheckYourResultsL";
            this.CheckYourResultsL.Size = new System.Drawing.Size(198, 27);
            this.CheckYourResultsL.TabIndex = 8;
            this.CheckYourResultsL.Text = "Check your results:";
            // 
            // GenPuz
            // 
            this.GenPuz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenPuz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenPuz.Location = new System.Drawing.Point(13, 364);
            this.GenPuz.Margin = new System.Windows.Forms.Padding(4);
            this.GenPuz.Name = "GenPuz";
            this.GenPuz.Size = new System.Drawing.Size(226, 41);
            this.GenPuz.TabIndex = 9;
            this.GenPuz.Text = "Generate new puzzle";
            this.GenPuz.UseVisualStyleBackColor = true;
            this.GenPuz.Click += new System.EventHandler(this.GenPuz_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Silver;
            this.progressBar.Location = new System.Drawing.Point(255, 375);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(415, 20);
            this.progressBar.TabIndex = 10;
            // 
            // StatusL
            // 
            this.StatusL.AutoSize = true;
            this.StatusL.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StatusL.Location = new System.Drawing.Point(443, 398);
            this.StatusL.Name = "StatusL";
            this.StatusL.Size = new System.Drawing.Size(50, 20);
            this.StatusL.TabIndex = 11;
            this.StatusL.Text = "Status";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 581);
            this.Controls.Add(this.StatusL);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.GenPuz);
            this.Controls.Add(this.CheckYourResultsL);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LeadB);
            this.Controls.Add(this.DifficultyL);
            this.Controls.Add(this.HardB);
            this.Controls.Add(this.MediumB);
            this.Controls.Add(this.EasyB);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainScreen";
            this.Text = "Sudoku";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EasyB;
        private Button MediumB;
        private Button HardB;
        private Label DifficultyL;
        private Button LeadB;
        private PictureBox pictureBox1;
        private Label NameL;
        private Button ExitB;
        private Label CheckYourResultsL;
        private Button GenPuz;
        private ProgressBar progressBar;
        private Label StatusL;
    }
}
namespace SudokuProject
{
    partial class Form1
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
            this.EasyB = new System.Windows.Forms.Button();
            this.MediumB = new System.Windows.Forms.Button();
            this.HardB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LeadB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EasyB
            // 
            this.EasyB.Location = new System.Drawing.Point(165, 238);
            this.EasyB.Name = "EasyB";
            this.EasyB.Size = new System.Drawing.Size(148, 44);
            this.EasyB.TabIndex = 0;
            this.EasyB.Text = "Легкий";
            this.EasyB.UseVisualStyleBackColor = true;
            // 
            // MediumB
            // 
            this.MediumB.Location = new System.Drawing.Point(165, 288);
            this.MediumB.Name = "MediumB";
            this.MediumB.Size = new System.Drawing.Size(148, 44);
            this.MediumB.TabIndex = 1;
            this.MediumB.Text = "Середній";
            this.MediumB.UseVisualStyleBackColor = true;
            // 
            // HardB
            // 
            this.HardB.Location = new System.Drawing.Point(165, 338);
            this.HardB.Name = "HardB";
            this.HardB.Size = new System.Drawing.Size(148, 44);
            this.HardB.TabIndex = 2;
            this.HardB.Text = "Складний";
            this.HardB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(144, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оберіть рівень складності:";
            // 
            // LeadB
            // 
            this.LeadB.Location = new System.Drawing.Point(165, 430);
            this.LeadB.Name = "LeadB";
            this.LeadB.Size = new System.Drawing.Size(148, 44);
            this.LeadB.TabIndex = 4;
            this.LeadB.Text = "Рейтинг";
            this.LeadB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(478, 517);
            this.Controls.Add(this.LeadB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HardB);
            this.Controls.Add(this.MediumB);
            this.Controls.Add(this.EasyB);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EasyB;
        private Button MediumB;
        private Button HardB;
        private Label label1;
        private Button LeadB;
    }
}
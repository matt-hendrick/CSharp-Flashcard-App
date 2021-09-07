
namespace FlashcardUI
{
    partial class ReviewCardForm
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
            this.goodButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.againButton = new System.Windows.Forms.Button();
            this.easyButton = new System.Windows.Forms.Button();
            this.cardTextLabel = new System.Windows.Forms.Label();
            this.flipButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goodButton
            // 
            this.goodButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.goodButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.goodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.goodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goodButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goodButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.goodButton.Location = new System.Drawing.Point(311, 389);
            this.goodButton.Name = "goodButton";
            this.goodButton.Size = new System.Drawing.Size(103, 61);
            this.goodButton.TabIndex = 20;
            this.goodButton.Text = "Good";
            this.goodButton.UseVisualStyleBackColor = true;
            this.goodButton.Click += new System.EventHandler(this.goodButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.hardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hardButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hardButton.Location = new System.Drawing.Point(171, 388);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(103, 61);
            this.hardButton.TabIndex = 19;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // againButton
            // 
            this.againButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.againButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.againButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.againButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.againButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.againButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.againButton.Location = new System.Drawing.Point(31, 388);
            this.againButton.Name = "againButton";
            this.againButton.Size = new System.Drawing.Size(103, 61);
            this.againButton.TabIndex = 18;
            this.againButton.Text = "Again";
            this.againButton.UseVisualStyleBackColor = true;
            this.againButton.Click += new System.EventHandler(this.againButton_Click);
            // 
            // easyButton
            // 
            this.easyButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.easyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.easyButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.easyButton.Location = new System.Drawing.Point(451, 389);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(103, 61);
            this.easyButton.TabIndex = 17;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // cardTextLabel
            // 
            this.cardTextLabel.AutoSize = true;
            this.cardTextLabel.BackColor = System.Drawing.Color.White;
            this.cardTextLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardTextLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cardTextLabel.Location = new System.Drawing.Point(210, 49);
            this.cardTextLabel.Name = "cardTextLabel";
            this.cardTextLabel.Size = new System.Drawing.Size(164, 47);
            this.cardTextLabel.TabIndex = 22;
            this.cardTextLabel.Text = "Card Text";
            this.cardTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flipButton
            // 
            this.flipButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.flipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.flipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.flipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flipButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flipButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.flipButton.Location = new System.Drawing.Point(257, 292);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(71, 75);
            this.flipButton.TabIndex = 23;
            this.flipButton.Text = "Flip Card";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.goBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.goBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goBackButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.goBackButton.Location = new System.Drawing.Point(469, 1);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(112, 41);
            this.goBackButton.TabIndex = 24;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            // 
            // ReviewCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.cardTextLabel);
            this.Controls.Add(this.goodButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.againButton);
            this.Controls.Add(this.easyButton);
            this.Name = "ReviewCardForm";
            this.Text = "ReviewCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goodButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button againButton;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Label cardTextLabel;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button goBackButton;
    }
}
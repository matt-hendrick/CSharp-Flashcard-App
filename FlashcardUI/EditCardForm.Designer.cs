
namespace FlashcardUI
{
    partial class EditCardForm
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
            this.editCardButton = new System.Windows.Forms.Button();
            this.cardBackLabel = new System.Windows.Forms.Label();
            this.cardFrontLabel = new System.Windows.Forms.Label();
            this.cardBackTextbox = new System.Windows.Forms.TextBox();
            this.cardFrontTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editCardButton
            // 
            this.editCardButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editCardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.editCardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCardButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editCardButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.editCardButton.Location = new System.Drawing.Point(205, 172);
            this.editCardButton.Name = "editCardButton";
            this.editCardButton.Size = new System.Drawing.Size(176, 64);
            this.editCardButton.TabIndex = 14;
            this.editCardButton.Text = "Edit Card";
            this.editCardButton.UseVisualStyleBackColor = true;
            this.editCardButton.Click += new System.EventHandler(this.editCardButton_Click);
            // 
            // cardBackLabel
            // 
            this.cardBackLabel.AutoSize = true;
            this.cardBackLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardBackLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cardBackLabel.Location = new System.Drawing.Point(160, 93);
            this.cardBackLabel.Name = "cardBackLabel";
            this.cardBackLabel.Size = new System.Drawing.Size(105, 30);
            this.cardBackLabel.TabIndex = 13;
            this.cardBackLabel.Text = "Card Back";
            // 
            // cardFrontLabel
            // 
            this.cardFrontLabel.AutoSize = true;
            this.cardFrontLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardFrontLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cardFrontLabel.Location = new System.Drawing.Point(160, 19);
            this.cardFrontLabel.Name = "cardFrontLabel";
            this.cardFrontLabel.Size = new System.Drawing.Size(110, 30);
            this.cardFrontLabel.TabIndex = 12;
            this.cardFrontLabel.Text = "Card Front";
            // 
            // cardBackTextbox
            // 
            this.cardBackTextbox.Location = new System.Drawing.Point(160, 126);
            this.cardBackTextbox.Name = "cardBackTextbox";
            this.cardBackTextbox.Size = new System.Drawing.Size(265, 23);
            this.cardBackTextbox.TabIndex = 11;
            // 
            // cardFrontTextbox
            // 
            this.cardFrontTextbox.Location = new System.Drawing.Point(159, 52);
            this.cardFrontTextbox.Name = "cardFrontTextbox";
            this.cardFrontTextbox.Size = new System.Drawing.Size(265, 23);
            this.cardFrontTextbox.TabIndex = 10;
            // 
            // EditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.editCardButton);
            this.Controls.Add(this.cardBackLabel);
            this.Controls.Add(this.cardFrontLabel);
            this.Controls.Add(this.cardBackTextbox);
            this.Controls.Add(this.cardFrontTextbox);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "EditCardForm";
            this.Text = "EditCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editCardButton;
        private System.Windows.Forms.Label cardBackLabel;
        private System.Windows.Forms.Label cardFrontLabel;
        private System.Windows.Forms.TextBox cardBackTextbox;
        private System.Windows.Forms.TextBox cardFrontTextbox;
    }
}

namespace FlashcardUI
{
    partial class CreateDeckForm
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
            this.createDeckButton = new System.Windows.Forms.Button();
            this.deckNameLabel = new System.Windows.Forms.Label();
            this.deckNameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createDeckButton
            // 
            this.createDeckButton.BackColor = System.Drawing.Color.White;
            this.createDeckButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createDeckButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createDeckButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.createDeckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createDeckButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createDeckButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createDeckButton.Location = new System.Drawing.Point(208, 112);
            this.createDeckButton.Name = "createDeckButton";
            this.createDeckButton.Size = new System.Drawing.Size(176, 64);
            this.createDeckButton.TabIndex = 14;
            this.createDeckButton.Text = "Create Deck";
            this.createDeckButton.UseVisualStyleBackColor = false;
            this.createDeckButton.Click += new System.EventHandler(this.createDeckButton_Click);
            // 
            // deckNameLabel
            // 
            this.deckNameLabel.AutoSize = true;
            this.deckNameLabel.BackColor = System.Drawing.Color.White;
            this.deckNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deckNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deckNameLabel.Location = new System.Drawing.Point(161, 23);
            this.deckNameLabel.Name = "deckNameLabel";
            this.deckNameLabel.Size = new System.Drawing.Size(121, 30);
            this.deckNameLabel.TabIndex = 12;
            this.deckNameLabel.Text = "Deck Name";
            // 
            // deckNameTextbox
            // 
            this.deckNameTextbox.BackColor = System.Drawing.Color.White;
            this.deckNameTextbox.Location = new System.Drawing.Point(160, 56);
            this.deckNameTextbox.Name = "deckNameTextbox";
            this.deckNameTextbox.ShortcutsEnabled = false;
            this.deckNameTextbox.Size = new System.Drawing.Size(265, 23);
            this.deckNameTextbox.TabIndex = 10;
            // 
            // CreateDeckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.createDeckButton);
            this.Controls.Add(this.deckNameLabel);
            this.Controls.Add(this.deckNameTextbox);
            this.Name = "CreateDeckForm";
            this.Text = "CreateDeckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createDeckButton;
        private System.Windows.Forms.Label deckNameLabel;
        private System.Windows.Forms.TextBox deckNameTextbox;
    }
}
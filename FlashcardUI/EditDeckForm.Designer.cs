
namespace FlashcardUI
{
    partial class EditDeckForm
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
            this.editDeckButton = new System.Windows.Forms.Button();
            this.deckNameLabel = new System.Windows.Forms.Label();
            this.deckNameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editDeckButton
            // 
            this.editDeckButton.BackColor = System.Drawing.Color.White;
            this.editDeckButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editDeckButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.editDeckButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editDeckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDeckButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editDeckButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.editDeckButton.Location = new System.Drawing.Point(208, 118);
            this.editDeckButton.Name = "editDeckButton";
            this.editDeckButton.Size = new System.Drawing.Size(176, 64);
            this.editDeckButton.TabIndex = 17;
            this.editDeckButton.Text = "Edit Deck";
            this.editDeckButton.UseVisualStyleBackColor = false;
            this.editDeckButton.Click += new System.EventHandler(this.editDeckButton_Click);
            // 
            // deckNameLabel
            // 
            this.deckNameLabel.AutoSize = true;
            this.deckNameLabel.BackColor = System.Drawing.Color.White;
            this.deckNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deckNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deckNameLabel.Location = new System.Drawing.Point(161, 29);
            this.deckNameLabel.Name = "deckNameLabel";
            this.deckNameLabel.Size = new System.Drawing.Size(121, 30);
            this.deckNameLabel.TabIndex = 16;
            this.deckNameLabel.Text = "Deck Name";
            // 
            // deckNameTextbox
            // 
            this.deckNameTextbox.BackColor = System.Drawing.Color.White;
            this.deckNameTextbox.Location = new System.Drawing.Point(160, 62);
            this.deckNameTextbox.Name = "deckNameTextbox";
            this.deckNameTextbox.ShortcutsEnabled = false;
            this.deckNameTextbox.Size = new System.Drawing.Size(265, 23);
            this.deckNameTextbox.TabIndex = 15;
            // 
            // EditDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.editDeckButton);
            this.Controls.Add(this.deckNameLabel);
            this.Controls.Add(this.deckNameTextbox);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "EditDeck";
            this.Text = "UpdateDeck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editDeckButton;
        private System.Windows.Forms.Label deckNameLabel;
        private System.Windows.Forms.TextBox deckNameTextbox;
    }
}
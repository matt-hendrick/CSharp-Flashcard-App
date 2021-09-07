
namespace FlashcardUI
{
    partial class ViewDeckForm
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
            this.reviewSelectedButton = new System.Windows.Forms.Button();
            this.createNewButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.cardListbox = new System.Windows.Forms.ListBox();
            this.editSelectedButton = new System.Windows.Forms.Button();
            this.deckNameLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reviewSelectedButton
            // 
            this.reviewSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.reviewSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.reviewSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.reviewSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reviewSelectedButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reviewSelectedButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.reviewSelectedButton.Location = new System.Drawing.Point(203, 388);
            this.reviewSelectedButton.Name = "reviewSelectedButton";
            this.reviewSelectedButton.Size = new System.Drawing.Size(103, 61);
            this.reviewSelectedButton.TabIndex = 14;
            this.reviewSelectedButton.Text = "Review";
            this.reviewSelectedButton.UseVisualStyleBackColor = true;
            this.reviewSelectedButton.Click += new System.EventHandler(this.reviewSelectedButton_Click);
            // 
            // createNewButton
            // 
            this.createNewButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createNewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createNewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.createNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewButton.Location = new System.Drawing.Point(34, 388);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(136, 61);
            this.createNewButton.TabIndex = 13;
            this.createNewButton.Text = "Create New";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.deleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteSelectedButton.Location = new System.Drawing.Point(454, 389);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(97, 61);
            this.deleteSelectedButton.TabIndex = 12;
            this.deleteSelectedButton.Text = "Delete";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // cardListbox
            // 
            this.cardListbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardListbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cardListbox.FormattingEnabled = true;
            this.cardListbox.ItemHeight = 30;
            this.cardListbox.Location = new System.Drawing.Point(2, 49);
            this.cardListbox.Name = "cardListbox";
            this.cardListbox.Size = new System.Drawing.Size(580, 334);
            this.cardListbox.TabIndex = 10;
            // 
            // editSelectedButton
            // 
            this.editSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.editSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSelectedButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSelectedButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.editSelectedButton.Location = new System.Drawing.Point(339, 389);
            this.editSelectedButton.Name = "editSelectedButton";
            this.editSelectedButton.Size = new System.Drawing.Size(82, 61);
            this.editSelectedButton.TabIndex = 16;
            this.editSelectedButton.Text = "Edit";
            this.editSelectedButton.UseVisualStyleBackColor = true;
            // 
            // deckNameLabel
            // 
            this.deckNameLabel.AutoSize = true;
            this.deckNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deckNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deckNameLabel.Location = new System.Drawing.Point(2, 7);
            this.deckNameLabel.Name = "deckNameLabel";
            this.deckNameLabel.Size = new System.Drawing.Size(121, 30);
            this.deckNameLabel.TabIndex = 17;
            this.deckNameLabel.Text = "Deck Name";
            // 
            // goBackButton
            // 
            this.goBackButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.goBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.goBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goBackButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.goBackButton.Location = new System.Drawing.Point(478, 1);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(104, 42);
            this.goBackButton.TabIndex = 18;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            // 
            // ViewDeckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.deckNameLabel);
            this.Controls.Add(this.editSelectedButton);
            this.Controls.Add(this.reviewSelectedButton);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.cardListbox);
            this.Name = "ViewDeckForm";
            this.Text = "ViewDeckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reviewSelectedButton;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.ListBox cardListbox;
        private System.Windows.Forms.Button editSelectedButton;
        private System.Windows.Forms.Label deckNameLabel;
        private System.Windows.Forms.Button goBackButton;
    }
}
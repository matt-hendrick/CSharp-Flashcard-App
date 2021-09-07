
namespace FlashcardUI
{
    partial class DeckSelectForm
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
            this.deckListbox = new System.Windows.Forms.ListBox();
            this.editSelectedButton = new System.Windows.Forms.Button();
            this.openSelectedButton = new System.Windows.Forms.Button();
            this.createNewButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deckListbox
            // 
            this.deckListbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deckListbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deckListbox.FormattingEnabled = true;
            this.deckListbox.ItemHeight = 30;
            this.deckListbox.Location = new System.Drawing.Point(3, 17);
            this.deckListbox.Name = "deckListbox";
            this.deckListbox.Size = new System.Drawing.Size(580, 364);
            this.deckListbox.TabIndex = 0;
            // 
            // editSelectedButton
            // 
            this.editSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.editSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSelectedButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSelectedButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.editSelectedButton.Location = new System.Drawing.Point(337, 389);
            this.editSelectedButton.Name = "editSelectedButton";
            this.editSelectedButton.Size = new System.Drawing.Size(82, 61);
            this.editSelectedButton.TabIndex = 20;
            this.editSelectedButton.Text = "Edit";
            this.editSelectedButton.UseVisualStyleBackColor = true;
            // 
            // openSelectedButton
            // 
            this.openSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.openSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.openSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.openSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSelectedButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openSelectedButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.openSelectedButton.Location = new System.Drawing.Point(204, 388);
            this.openSelectedButton.Name = "openSelectedButton";
            this.openSelectedButton.Size = new System.Drawing.Size(103, 61);
            this.openSelectedButton.TabIndex = 19;
            this.openSelectedButton.Text = "Open";
            this.openSelectedButton.UseVisualStyleBackColor = true;
            this.openSelectedButton.Click += new System.EventHandler(this.openSelectedButton_Click);
            // 
            // createNewButton
            // 
            this.createNewButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createNewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createNewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.createNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewButton.Location = new System.Drawing.Point(38, 388);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(136, 61);
            this.createNewButton.TabIndex = 18;
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
            this.deleteSelectedButton.Location = new System.Drawing.Point(449, 389);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(97, 61);
            this.deleteSelectedButton.TabIndex = 17;
            this.deleteSelectedButton.Text = "Delete";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // DeckSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.editSelectedButton);
            this.Controls.Add(this.openSelectedButton);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.deckListbox);
            this.Name = "DeckSelectForm";
            this.Text = "DeckSelectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox deckListbox;
        private System.Windows.Forms.Button editSelectedButton;
        private System.Windows.Forms.Button openSelectedButton;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Button deleteSelectedButton;
    }
}
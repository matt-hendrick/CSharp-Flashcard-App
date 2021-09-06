using FlashcardLibrary;
using FlashcardLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashcardUI
{
    public partial class CreateDeckForm : Form
    {
        public CreateDeckForm()
        {
            InitializeComponent();
        }

        private void createDeckButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DeckModel deck = new DeckModel();

                deck.DeckName = deckNameTextbox.Text;

                // TODO - make ID = to current logged in user
                DatabaseConnector.Connection.CreateDeck(deck, 1);
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            // if the field is empty, return false
            if (deckNameTextbox.Text.Length < 1) return false;

            return true;
        }
    }
}

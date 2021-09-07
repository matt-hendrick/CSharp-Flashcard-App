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
    public partial class EditDeckForm : Form
    {
        IDeckRequester callingForm;
        private int selectedDeckID = 0; 

        public EditDeckForm(IDeckRequester caller, int DeckID)
        {
            InitializeComponent();

            callingForm = caller;

            selectedDeckID = DeckID;
        }

        private void editDeckButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DeckModel deck = new DeckModel();

                deck.DeckName = deckNameTextbox.Text;

                DatabaseConnector.Connection.EditDeck(deck, selectedDeckID);

                callingForm.DeckEditComplete(deck);

                this.Close();
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

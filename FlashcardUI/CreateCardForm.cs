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
    public partial class CreateCardForm : Form
    {
        ICardRequester callingForm;

        public CreateCardForm(ICardRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void createCardButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CardModel card = new CardModel();

                card.CardFront = cardFrontTextbox.Text;
                card.CardBack = cardBackTextbox.Text;

                // TODO - make IDs = to current logged in user and active deck
                DatabaseConnector.Connection.CreateCard(card, 1);

                callingForm.CardCreationComplete(card);

                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            // if any of the fields are empty, return false
            if (cardFrontTextbox.Text.Length < 1 || cardBackTextbox.Text.Length < 1) return false;

            return true;
        }
    }
}

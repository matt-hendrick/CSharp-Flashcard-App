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
    public partial class EditCardForm : Form
    {
        ICardRequester callingForm;
        private int selectedCardID = 0;

        public EditCardForm(ICardRequester caller, int CardID)
        {
            InitializeComponent();

            callingForm = caller;

            selectedCardID = CardID;
        }

        private void editCardButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CardModel card = new CardModel();

                card.CardFront = cardFrontTextbox.Text;
                card.CardBack = cardBackTextbox.Text;

                DatabaseConnector.Connection.EditCardText(card, selectedCardID);

                callingForm.CardEditComplete(card);

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

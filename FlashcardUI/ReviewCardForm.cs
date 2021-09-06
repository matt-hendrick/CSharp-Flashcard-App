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
    public partial class ReviewCardForm : Form
    {
        private CardModel currentCard;
        private bool frontVisible = true;

        public ReviewCardForm(CardModel card)
        {
            InitializeComponent();

            currentCard = card;

            LoadCardFront(currentCard);
        }

        private void LoadCardFront(CardModel card)
        {
            cardTextLabel.Text = card.CardFront;
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            cardTextLabel.Text = null;

            if (frontVisible)
            {
                cardTextLabel.Text = currentCard.CardBack;

                frontVisible = false;
            }
            else
            {
                cardTextLabel.Text = currentCard.CardFront;

                frontVisible = true;
            }
        }
    }
}

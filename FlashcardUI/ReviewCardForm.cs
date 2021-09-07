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
        private List<CardModel> cardsInDeck = new List<CardModel>();
        private int currentIndex = 0;
        private bool frontVisible = true;

        public ReviewCardForm(List<CardModel> cardList)
        {
            InitializeComponent();

            cardsInDeck = cardList;

            LoadCardFront(cardsInDeck[currentIndex]);
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
                cardTextLabel.Text = cardsInDeck[currentIndex].CardBack;

                frontVisible = false;
            }
            else
            {
                cardTextLabel.Text = cardsInDeck[currentIndex].CardFront;

                frontVisible = true;
            }
        }
    }
}

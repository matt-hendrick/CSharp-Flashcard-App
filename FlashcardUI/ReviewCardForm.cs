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
    public partial class ReviewCardForm : Form
    {
        private List<CardModel> cardsInDeck = new List<CardModel>();
        private int currentIndex = 0;
        private bool frontVisible = true;

        public ReviewCardForm(List<CardModel> cardList)
        {
            InitializeComponent();

            cardsInDeck = cardList;

            InitializeCard();
        }

        private void InitializeCard()
        {
            cardTextLabel.Text = cardsInDeck[currentIndex].CardFront;
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

        private void IterateThroughDeck()
        {
            if (currentIndex >= cardsInDeck.Count - 1)
            {
                currentIndex = 0;
            }
            else currentIndex++;
            InitializeCard();
        }

        private void againButton_Click(object sender, EventArgs e)
        {
            DatabaseConnector.Connection.EditCardDifficulty(cardsInDeck[currentIndex], "again", cardsInDeck[currentIndex].ID);
            IterateThroughDeck();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            DatabaseConnector.Connection.EditCardDifficulty(cardsInDeck[currentIndex], "hard", cardsInDeck[currentIndex].ID);
            IterateThroughDeck();
        }

        private void goodButton_Click(object sender, EventArgs e)
        {
            DatabaseConnector.Connection.EditCardDifficulty(cardsInDeck[currentIndex], "good", cardsInDeck[currentIndex].ID);
            IterateThroughDeck();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            DatabaseConnector.Connection.EditCardDifficulty(cardsInDeck[currentIndex], "easy", cardsInDeck[currentIndex].ID);
            IterateThroughDeck();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

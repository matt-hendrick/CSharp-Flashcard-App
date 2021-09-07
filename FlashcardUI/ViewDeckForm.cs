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
    public partial class ViewDeckForm : Form, ICardRequester
    {

        private DeckModel currentDeck;
        BindingList<CardModel> availableCards = new BindingList<CardModel>();

        public ViewDeckForm(DeckModel deck)
        {
            InitializeComponent();

            currentDeck = deck;

            LoadCards(currentDeck);

            InitializeList();
        }

        private void LoadCards(DeckModel deck)
        {
            List<CardModel> cardsInDeck = DatabaseConnector.Connection.GetAll_Cards(deck.ID);

            foreach (CardModel card in cardsInDeck)
            {
                availableCards.Add(card);
            }
        }
        
        private void InitializeList() {
            cardListbox.DataSource = availableCards;
            cardListbox.DisplayMember = "CombinedName";
        }

        private void reviewSelectedButton_Click(object sender, EventArgs e)
        {
            List<CardModel> cardsInDeck = new List<CardModel>();

            foreach (CardModel card in availableCards)
            {
                cardsInDeck.Add(card);
            }

            if (cardsInDeck != null && cardsInDeck.Count > 0)
            {
                ReviewCardForm form = new ReviewCardForm(cardsInDeck);
                form.Show();
            }

    }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            CreateCardForm form = new CreateCardForm(this, currentDeck.ID);
            form.Show();
        }

        public void CardCreationComplete(CardModel card)
        {
            availableCards.Add(card);
            InitializeList();
        }
    }
}

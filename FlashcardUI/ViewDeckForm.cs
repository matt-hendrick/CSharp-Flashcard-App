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
    public partial class ViewDeckForm : Form
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
    }
}

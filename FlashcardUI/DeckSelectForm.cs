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
    public partial class DeckSelectForm : Form, IDeckRequester
    { 
        private List<DeckModel> availableDecks = DatabaseConnector.Connection.GetAll_Decks();
        private DeckModel selectedDeck = new DeckModel();

        public DeckSelectForm()
        {
            InitializeComponent();

            InitializeDeckList();
        }

        private void InitializeDeckList()
        {
            deckListbox.DataSource = null;

            deckListbox.DataSource = availableDecks;
            deckListbox.DisplayMember = "DeckName";
        }

        private void openSelectedButton_Click(object sender, EventArgs e)
        {
            selectedDeck = (DeckModel)deckListbox.SelectedItem;

            if (selectedDeck != null)
            {
                 ViewDeckForm form = new ViewDeckForm(selectedDeck);
                 form.Show();
            }
           
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            CreateDeckForm form = new CreateDeckForm(this);
            form.Show();
        }

        public void DeckCreationComplete(DeckModel deck)
        {
            availableDecks.Add(deck);
            InitializeDeckList();
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            selectedDeck = (DeckModel)deckListbox.SelectedItem;

            if (selectedDeck != null)
            {
                DatabaseConnector.Connection.DeleteDeck(selectedDeck.ID);

                availableDecks.Remove(selectedDeck);
            }
            InitializeDeckList();
        }

        private void editSelectedButton_Click(object sender, EventArgs e)
        {
            selectedDeck = (DeckModel)deckListbox.SelectedItem;

            if (selectedDeck != null) 
            { 
                EditDeckForm form = new EditDeckForm(this, selectedDeck.ID);
                form.Show();
            }
        }

        public void DeckEditComplete(DeckModel deck)
        {
            availableDecks.Remove(selectedDeck);
            availableDecks.Add(deck);
            InitializeDeckList();
        }
    }
}

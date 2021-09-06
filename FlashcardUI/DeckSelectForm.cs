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
        // TODO - use active user ID to pull decks
        private List<DeckModel> availableDecks = DatabaseConnector.Connection.GetAll_Decks(1);

        public DeckSelectForm()
        {
            InitializeComponent();

            InitializeList();
        }

        private void InitializeList()
        {
            deckListbox.DataSource = null;

            deckListbox.DataSource = availableDecks;
            deckListbox.DisplayMember = "DeckName";
        }

        private void openSelectedButton_Click(object sender, EventArgs e)
        {
            DeckModel deck = (DeckModel)deckListbox.SelectedItem;

            if (deck != null)
            {
                 ViewDeckForm form = new ViewDeckForm(deck);
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
            InitializeList();
        }
    }
}

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
        // TODO - use active deck ID to pull cards
        private List<CardModel> availableCards = DatabaseConnector.Connection.GetAll_Cards(1);

        public ViewDeckForm()
        {
            InitializeComponent();

            InitializeList();
        }

        private void InitializeList() {
            cardListbox.DataSource = null;

            cardListbox.DataSource = availableCards;
            cardListbox.DisplayMember = "CombinedName";
        }
    }
}

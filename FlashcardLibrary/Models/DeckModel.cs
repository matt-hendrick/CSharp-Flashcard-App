using System;
using System.Collections.Generic;
using System.Text;

namespace FlashcardLibrary.Models
{
    /// <summary>
    /// Represents a flashcard deck
    /// </summary>
    public class DeckModel
    {
        /// <summary>
        /// Unique ID for the deck
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The name of the deck
        /// </summary>
        public string DeckName { get; set; }

        /// <summary>
        /// The list of cards in the deck
        /// </summary>
        public List<CardModel> CardList { get; set; }

        /// <summary>
        /// Unique ID for the user
        /// </summary>
        public int UserID { get; set; }
    }
}

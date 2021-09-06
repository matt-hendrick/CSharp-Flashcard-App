﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlashcardLibrary.Models
{
    /// <summary>
    /// Represents one flashcard
    /// </summary>
    public class CardModel
    {  
        /// <summary>
        /// Unique ID for the flashcard
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The front of the flashcard
        /// </summary>
        public string CardFront { get; set; }

        /// <summary>
        /// The back of the flashcard
        /// </summary>
        public string CardBack { get; set; }

        /// <summary>
        /// Unique ID for the user
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Unique ID for the deck
        /// </summary>
        public int DeckID { get; set; }
    }
}

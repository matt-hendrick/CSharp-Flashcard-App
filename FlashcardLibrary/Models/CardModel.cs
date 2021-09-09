using System;
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
        /// Unique ID for the deck
        /// </summary>
        public int DeckID { get; set; }

        /// <summary>
        /// Difficulty level of the card
        /// </summary>
        public double Difficulty { get; set; }

        /// <summary>
        /// Combined front/back card text
        /// </summary>
        public string CombinedName
        {
            get
            {
                return $"{CardFront} === {CardBack}";
            }
        }
    }
}

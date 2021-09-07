using FlashcardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlashcardUI
{
    public interface ICardRequester
    {
        void CardCreationComplete(CardModel card);

        void CardEditComplete(CardModel card);
    }
}

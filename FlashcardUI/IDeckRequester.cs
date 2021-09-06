using FlashcardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlashcardUI
{
    public interface IDeckRequester
    {
        void DeckCreationComplete(DeckModel deck);
    }
}

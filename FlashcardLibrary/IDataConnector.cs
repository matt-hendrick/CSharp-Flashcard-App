using FlashcardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlashcardLibrary
{
    public interface IDataConnector
    {
        void CreateUser(UserModel user);

        void CreateDeck(DeckModel deck);

        void CreateCard(CardModel card);
    }
}

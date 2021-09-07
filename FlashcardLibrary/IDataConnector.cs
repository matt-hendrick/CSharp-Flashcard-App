using FlashcardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlashcardLibrary
{
    public interface IDataConnector
    {

        void CreateDeck(DeckModel deck);

        void CreateCard(CardModel card, int DeckID);

        List<DeckModel> GetAll_Decks();

        List<CardModel> GetAll_Cards(int DeckID);

        void DeleteDeck(int DeckID);

        void DeleteCard(int CardID);
    }
}

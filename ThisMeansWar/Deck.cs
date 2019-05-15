using System;
using System.Collections.Generic;

namespace ThisMeansWar
{
    public class Deck
    {
        static Deck()
        {
            _cardsInDeck = new List<Card>();
            foreach (int i in Enum.GetValues(typeof(Suit)))
            {
                foreach (int j in Enum.GetValues(typeof(FaceValue)))
                {
                    _cardsInDeck.Add(new Card() { Suit = (Suit)i, FaceValue = (FaceValue)j });

                }
            }
        }

        private static List<Card> _cardsInDeck { get; set; }

        private static List<Card> ShuffleDeck()
        {
            var cardsToShuffle = _cardsInDeck;
            var shuffledCards = new List<Card>();
            var random = new Random();
            while (cardsToShuffle.Count > 0)
            {
                var index = random.Next(0, cardsToShuffle.Count);
                shuffledCards.Add(cardsToShuffle[index]);
                cardsToShuffle.RemoveAt(index);
            }
            return shuffledCards;
        }

        public static void DealCards(Player playerOne, Player playerTwo)
        {
            var deck = Deck.ShuffleDeck();
            for (var i = 0; i < deck.Count; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    playerOne.Hand.Add(deck[i]);
                }
                else
                {
                    playerTwo.Hand.Add(deck[i]);
                }

            }

        }



    }
}

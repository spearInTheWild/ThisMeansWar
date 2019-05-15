using System;
using System.Collections.Generic;

namespace ThisMeansWar
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();

        public Card PlayCard(int cardsToDraw)
        {
            var cardToPlay = Hand[cardsToDraw];
            AnnounceCard(cardToPlay);

            return cardToPlay;
        }

        public void WinRound(List<Card> cardsWon)
        {
            foreach (var card in cardsWon)
            {
                if (Hand.Contains(card))
                {
                    Hand.Remove(card);
                }
                Hand.Add(card);
            }
        }

        public void LoseRound(List<Card> cardsLost)
        {
            foreach (var card in cardsLost)
            {
                if (Hand.Contains(card))
                {
                    Hand.Remove(card);
                }

            }
        }

        public List<Card> GetPlayedCards(int rounds)
        {
            var playedCardList = new List<Card>();
            for (var i = 0; i <= rounds; i++)
            {
                playedCardList.Add(Hand[i]);
            }
            return playedCardList;
        }

        public void AnnounceCard(Card card)
        {
            Console.WriteLine($"{Name} plays the {card.FaceValue} of {card.Suit}.");
        }


    }
}

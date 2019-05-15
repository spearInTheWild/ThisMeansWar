using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ThisMeansWar.Tests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void CreateDeckMakesStandardCardDeck()
        {
            // -- Arrange
            var standardDeck = new List<Card>
            {
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Two }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Three }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Four }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Five }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Six }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Seven }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Eight }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Nine }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Ten }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Jack }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Queen }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.King }),
                (new Card() { Suit = Suit.Clubs, FaceValue = FaceValue.Ace }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Two }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Three }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Four }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Five }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Six }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Seven }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Eight }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Nine }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Ten }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Jack }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Queen }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.King }),
                (new Card() { Suit = Suit.Diamonds, FaceValue = FaceValue.Ace }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Two }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Three }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Four }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Five }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Six }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Seven }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Eight }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Nine }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Ten }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Jack }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Queen }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.King }),
                (new Card() { Suit = Suit.Hearts, FaceValue = FaceValue.Ace }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Two }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Three }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Four }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Five }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Six }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Seven }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Eight }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Nine }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Ten }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Jack }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Queen }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.King }),
                (new Card() { Suit = Suit.Spades, FaceValue = FaceValue.Ace })
            };

            var playerOne = new Player("Matt");
            var playerTwo = new Player("Sam");

            // -- Act
            Deck.DealCards(playerOne, playerTwo);
            var deck = playerOne.Hand.Concat(playerTwo.Hand).ToList();

            // -- Assert
            CollectionAssert.AreEquivalent(deck, standardDeck);
        }

        [TestMethod]
        public void DealDeckDealsCorrectAmountOfCards()
        {
            // -- Arrange
            var playerOne = new Player("Matt");
            var playerTwo = new Player("Sam");

            // -- Act
            Deck.DealCards(playerOne, playerTwo);

            // -- Assert
            Assert.AreEqual(playerOne.Hand.Count, 26);
            Assert.AreEqual(playerTwo.Hand.Count, 26);
        }
    }
}

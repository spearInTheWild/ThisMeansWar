using System;
using System.Collections.Generic;

namespace ThisMeansWar
{
    public class BattleRound
    {
        public BattleRound()
        {
            RoundNumber += 1;
        }
        public static int RoundNumber { get; set; }

        private Player _playerOne;
        private Player _playerTwo;
        private Player _winner;
        private Player _loser;

        private List<Card> _cardsPlayedInRound = new List<Card>();

        public void Execute(Player playerOne, Player playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
            var i = 0;
            var currentPlayerOneCard = _playerOne.PlayCard(i);
            var currentPlayerTwoCard = _playerTwo.PlayCard(i);


            if (currentPlayerOneCard.FaceValue == currentPlayerTwoCard.FaceValue)
            {
                Console.WriteLine("--------This means war!--------");
                if (_playerOne.Hand.Count > 2 && _playerTwo.Hand.Count > 2)
                {
                    while (currentPlayerOneCard.FaceValue == currentPlayerTwoCard.FaceValue)
                    {
                        i += 2;
                        currentPlayerOneCard = _playerOne.PlayCard(i);
                        currentPlayerTwoCard = _playerTwo.PlayCard(i);
                    }
                    SetWinnerAndLoser(currentPlayerOneCard, currentPlayerTwoCard);
                }
                else if (_playerOne.Hand.Count < 3)
                {
                    i = _playerOne.Hand.Count - 1;
                    _winner = playerTwo;
                    _loser = playerOne;

                }
                else if (_playerTwo.Hand.Count < 3)
                {
                    i = playerTwo.Hand.Count - 1;
                    _winner = playerOne;
                    _loser = playerTwo;
                }
            }
            else
            {
                SetWinnerAndLoser(currentPlayerOneCard, currentPlayerTwoCard);
            }


            foreach (var card in _winner.GetPlayedCards(i))
            {
                _cardsPlayedInRound.Add(card);
            }
            foreach (var card in _loser.GetPlayedCards(i))
            {
                _cardsPlayedInRound.Add(card);
            }

            _winner.WinRound(_cardsPlayedInRound);
            _loser.LoseRound(_cardsPlayedInRound);
            DeclareRoundWinner();
            PrintCardCount(_playerOne, _playerTwo);
        }

        private void SetWinnerAndLoser(Card playerOneCard, Card playerTwoCard)
        {
            if ((int)playerOneCard.FaceValue > (int)playerTwoCard.FaceValue)
            {
                _winner = _playerOne;
                _loser = _playerTwo;
            }
            else
            {
                _winner = _playerTwo;
                _loser = _playerOne;
            }
        }

        private void DeclareRoundWinner()
        {
            Console.WriteLine($"{_winner.Name} Wins this round.");
        }

        private void PrintCardCount(Player player1, Player player2)
        {
            Console.WriteLine($"Card Counts: {player1.Name} has {player1.Hand.Count} cards; {player2.Name} has {player2.Hand.Count} cards.");
            Console.WriteLine("------------------------------------------------------------------");
        }



    }
}

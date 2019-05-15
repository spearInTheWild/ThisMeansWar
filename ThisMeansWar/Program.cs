using System;

namespace ThisMeansWar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Game Of War, enter your name and press 'Enter' to begin: ");

            var player = new Player(Console.ReadLine());
            var computerPlayer = new Player("RUDI");

            Console.WriteLine($"Welcome {player.Name}! You will be playing our computer {computerPlayer.Name}. Good Luck!");
            Console.WriteLine("Press 'Enter' to Continue");
            Console.ReadLine();

            Deck.DealCards(player, computerPlayer);

            while (player.Hand.Count > 0 && computerPlayer.Hand.Count > 0)
            {
                var round = new BattleRound();
                Console.WriteLine($"Battle Round {BattleRound.RoundNumber}:");
                round.Execute(player, computerPlayer);
            }

            var champion = (player.Hand.Count > 0) ? player.Name : computerPlayer.Name;
            if (champion == player.Name)
            {
                Console.WriteLine($"Congratulations, {champion}! You've won.");
            }
            else
            {
                Console.WriteLine($"Sorry {player.Name}, {computerPlayer.Name} got the best of you! Better luck next time.");
            }


            Console.ReadLine();
        }
    }

}
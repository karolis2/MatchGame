using CardDealingService.CoreDomain;

namespace CardDealingService
{
    public class GameEngine
    {
        private static Dictionary<string, int> _players = new() {{"Player 1", 0}, {"Player 2", 0}};
        private static Random _random = new();

        public static void PlayGame(int packsCount)
        {
            Console.WriteLine("Let's play!");

            var cards = CardDealing.GenerateCardDecksByInput(packsCount);
            var shuffledDeck = ShuffleTheDeck(cards).ToList();
            var playedCards = new List<Card>();

            for (var i = 0; i < shuffledDeck.Count - 1; i++)
            {
                PlayTheMove(shuffledDeck, i, playedCards);

                //TODO: what do we do if no matches?
            }

            DeclareTheWinner();
        }

        private static void PlayTheMove(IReadOnlyList<Card> shuffledDeck, int i, List<Card> playedCards)
        {
            var current = shuffledDeck[i];
            var nextCard = shuffledDeck[i + 1];

            playedCards.Add(current);

            if (current.Value == nextCard.Value)
            {
                RandomizeTheWinner(playedCards);
            }
        }

        private static void DeclareTheWinner()
        {
            var winner = _players.MaxBy(kvp => kvp.Value).Key;

            Console.WriteLine(winner + " is the winner");
        }

        private static void RandomizeTheWinner(List<Card> playedCards)
        {
            var matchWinner = _players.ElementAt(_random.Next(_players.Count)).Key;

            var cardsInHands = _players[matchWinner];

            _players[matchWinner] = cardsInHands + playedCards.Count;

            Console.WriteLine(matchWinner + $" Takes takes the cards{playedCards.Count}!");

            playedCards.Clear();
        }

        private static IEnumerable<Card> ShuffleTheDeck(IEnumerable<Card> cards)
        {
            return cards.OrderBy(card => _random.Next());
        }
    }
}

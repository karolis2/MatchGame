using CardDealingService.CoreDomain;

namespace CardDealingService;

public static class CardDealing
{
    public static List<Card> GenerateCardDecksByInput(int packs)
    {
        var deck = new List<Card>();
        for (var i = 0; i < packs; i++)
        {
            deck.AddRange(GenerateCardDeck());
        }

        return deck;
    }

    public static List<Card> GenerateCardDeck()
    {
        var deck = new List<Card>();

        var cardValues = Enum.GetValues(typeof(Values)).Cast<Values>();
        var cardSuits = Enum.GetValues(typeof(Suits)).Cast<Suits>();

        GenerateSingleDeck(cardValues, cardSuits, deck);

        return deck;
    }

    private static void GenerateSingleDeck(IEnumerable<Values> cardValues, IEnumerable<Suits> cardSuits, List<Card> deck)
    {
        foreach (var value in cardValues)
        {
            GenerateSuitedCards(cardSuits, value, deck);
        }
    }

    private static void GenerateSuitedCards(IEnumerable<Suits> cardSuits, Values value, ICollection<Card> deck)
    {
        foreach (var suit in cardSuits)
        {
            var card = new Card(suit, value);
            deck.Add(card);
        }
    }
}
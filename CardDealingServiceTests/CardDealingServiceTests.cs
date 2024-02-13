using CardDealingService;

namespace CardDealingServiceTests;

public class CardDealingServiceTests
{
    [Fact]
    public void Should_ReturnExactlyFiftyTwoCards_When_SinglePackOfCardsProvidedAsParameter()
    {
        var singleDeck = CardDealing.GenerateCardDeck();

        Assert.True(singleDeck.Count == 52, "Should return 52 cards.");
    }

    [Fact]
    public void Should_ReturnExactlyHundredAndFourCards_When_TwoPacksOfCardsProvidedAsParameter()
    {
        var singleDeck = CardDealing.GenerateCardDecksByInput(2);

        Assert.True(singleDeck.Count == 104, "Should return 104 cards.");
    }
}
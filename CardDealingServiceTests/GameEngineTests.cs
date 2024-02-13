using CardDealingService;

namespace CardDealingServiceTests;

public class GameEngineTests
{
    [Fact]
    public void Should_ReturnTheWinner_When_GameIsPlayedOnce()
    {
        GameEngine.PlayGame(1);
        // Should Assert if the winner is returned.
    }
}
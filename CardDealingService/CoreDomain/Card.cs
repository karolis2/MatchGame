namespace CardDealingService.CoreDomain;

public class Card
{
    public Suits Suits { get; set; }
    public Values Value { get; set; }

    public Card(Suits suits, Values value)
    {
        Suits = suits;
        Value = value;
    }
}
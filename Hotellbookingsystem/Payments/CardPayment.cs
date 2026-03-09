namespace Hotellbookingsystem.Payments;

public class CardPayment : IPayable
{
    private string cardNumber;
    private string cardType;

    public CardPayment(string CardNumber, string CardType)
    {
        CardNumber = cardNumber;
        CardType = cardType;
    }
    
}
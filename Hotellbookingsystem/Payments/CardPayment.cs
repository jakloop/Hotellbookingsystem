namespace Hotellbookingsystem.Payments;

public class CardPayment : IPayable
{
    private readonly string cardNumber;
    private readonly string cardType;

    //<summary
    // Cardpayment constructor
    //</summary>
    public CardPayment(string CardNumber, string CardType)
    {
        if (!IsExactlyFourDigitsInput(CardNumber))
        {
            throw new ArgumentException("Card number must be exactly 4 digits");
        }
        this.cardNumber = CardNumber;
        this.cardType = CardType;
        
    }
    
    
    public bool ProcessPayment(decimal amount)
    {
        return true;
    }
    
    public string GetPaymentInfo()
    {
        return $"Card payment approved:{cardType} {cardNumber}";
    }
    
    // method to verify if the input is exactly 4 digits
    // Accessed from google AI
    public static bool IsExactlyFourDigitsInput(string input)
    {
        // Check if it's all digits and exactly 4 characters long
        bool isFourDigits = input.All(char.IsDigit) && input.Length == 4;
        
        return isFourDigits;
    }
}
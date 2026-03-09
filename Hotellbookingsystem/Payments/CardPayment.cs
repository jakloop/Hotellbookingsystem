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
    
    
    public bool ProcessPayment()
    {
        return true;
    }
    //TODO fix implentation of amount etc.
    public string GetPaymentInfo(decimal amount)
    {
        Console.WriteLine($"Card Number: {cardNumber}");
        Console.WriteLine($"Card Type: {cardType}");
        Console.WriteLine($"Amount: {amount}");
        if (ProcessPayment())
            Console.WriteLine("Payment was Successful!");
        else
            Console.WriteLine("Payment Failed!");
        return "That's all.";
    }
    
}
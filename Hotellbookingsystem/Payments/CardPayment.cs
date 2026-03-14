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
    
    
    public bool ProcessPayment(decimal amount)
    {
        return true;
    }
    //TODO fix implentation of amount etc.
    
    public string GetPaymentInfo(decimal amount)
    {
        Console.WriteLine($"Card Number: {cardNumber}");
        Console.WriteLine($"Card Type: {cardType}");
        Console.WriteLine($"Amount: {amount}");
        if (ProcessPayment(amount))
            Console.WriteLine("Payment was Successful!");
        else
            Console.WriteLine("Payment Failed!");
        return "That's all.";
    }
    
    // method to verify if the input is exactly 4 digits
    // Accessed from google AI
    public static bool IsExactlyFourDigitsInput(string input)
    {
        // Trim whitespace first to handle inputs like " 1234 "
        string trimmedInput = input.Trim();

        // Check if it's all digits and exactly 4 characters long
        bool isFourDigits = trimmedInput.All(char.IsDigit) && trimmedInput.Length == 4;
        
        return isFourDigits;
    }
}
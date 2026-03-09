namespace Hotellbookingsystem.Payments;

public class VippsPayment : IPayable
{
    public string phoneNumber;
    public VippsPayment(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }
    public string PhoneNumber { get; set; }
    
    public string GetPaymentInfo(decimal amount)
    {
        {
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Amount: {amount}");
            if (ProcessPayment(amount))
                Console.WriteLine("Payment was Successful!");
            else
                Console.WriteLine("Payment Failed!");
            return "That's all.";
        }
    }
    
    public bool ProcessPayment(decimal amount)
    {
        return true;
    }
}
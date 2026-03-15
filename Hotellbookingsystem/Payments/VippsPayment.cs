namespace Hotellbookingsystem.Payments;

public class VippsPayment : IPayable
{
    private readonly string phoneNumber;
    public VippsPayment(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }
    public string PhoneNumber { get; set; }
    
    public string GetPaymentInfo()
    {
        return $"Vipps payment approved: {phoneNumber}";
    }
    
    public bool ProcessPayment(decimal amount)
    {
        return true;
    }
}
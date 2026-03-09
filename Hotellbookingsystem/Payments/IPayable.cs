namespace Hotellbookingsystem.Payments;

public interface IPayable
{
    private bool ProcessPayment(decimal amount)
    {
        return true;
    }

    public string GetPaymentInfo(decimal amount);
}

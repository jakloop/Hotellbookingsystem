namespace Hotellbookingsystem.Payments;

public interface IPayable
{
    public bool ProcessPayment(decimal amount);

    public string GetPaymentInfo(decimal amount);
}

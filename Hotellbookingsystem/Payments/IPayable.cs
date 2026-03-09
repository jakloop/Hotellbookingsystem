namespace Hotellbookingsystem.Payments;

public interface IPayable
{
    private bool ProcessPayment(decimal amount)
    {
        Console.WriteLine("Processing Payment...");
        Console.WriteLine($"Amount: {amount}");
        return true;
    }

    private string GetPaymentInfo()
    {
        throw new NotImplementedException();
    }
}

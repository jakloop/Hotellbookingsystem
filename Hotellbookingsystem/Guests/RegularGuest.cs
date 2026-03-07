namespace Hotellbookingsystem.Guests;
//<summary>
// Regular guest class
//</summary>
public class RegularGuest : Guest
{
    private const int Max_Bookings = 3;
    public RegularGuest(string name, string email) : base(name, email)
    {
    }
    public override decimal GetDiscount(decimal basePrice)
    {
        return basePrice;
    }
    
}
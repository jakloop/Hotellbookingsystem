
namespace Hotellbookingsystem.Guests;
//<summary>
// Vip guest class
// gets 15% discount
// max 10 active bookings
// loyalty points (int) 10 points per booking
//</summary>
public class VipGuest : Guest
{
    private const int Max_Bookings = 10;
    
    public VipGuest(string name, string email) : base(name, email)
    {
        LoyaltyPoints = 0;
    }
    public int LoyaltyPoints { get; private set; }
    
    public override decimal GetDiscount(decimal bacePrice)
    {
        return bacePrice * 0.15m;
    }

    public void AddLoyaltyPointsBooking()
    {
        LoyaltyPoints+= 10;
    }
}
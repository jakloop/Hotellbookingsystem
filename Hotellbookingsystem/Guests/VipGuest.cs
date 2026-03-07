
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
    private const int loyaltyPointsAdder = 10;
    private int loyaltyPoints;


    public VipGuest(string name, string email) : base(name, email)
    {
    }
    
    public override decimal GetDiscount(decimal basePrice)
    {
        return basePrice * 0.85m;
    }
}
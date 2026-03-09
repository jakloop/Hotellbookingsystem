using Hotellbookingsystem.Guests;
using Hotellbookingsystem.Payments;

namespace Hotellbookingsystem.Bookings;
//<summary>
// booking class
// handles checking in and out, and verifies payment
//</summary>
public class Booking : Guest
{
    private string BookingId;
    private string UserId;
    private DateTime CheckInDate;
    private DateTime CheckOutDate;
    IPayable PaymentMethod;
    public Booking(string name, string email) : base(name, email)
    {
        
    }
}
using Hotellbookingsystem.Guests;
using Hotellbookingsystem.Payments;
using Hotellbookingsystem.Rooms;
using Hotellbookingsystem.Utils;

namespace Hotellbookingsystem.Bookings;
//<summary>
// booking class
// handles checking in and out, and verifies payment
//</summary>
public class Booking
{
    // AI-help on these fields.
    private readonly string BookingId;
    private readonly Room room;
    private readonly Guest guest;
    private readonly DateTime CheckInDate;
    private readonly DateTime CheckOutDate;
    private readonly IPayable paymentMethod;
    //TODO check that this isn't able to change outside the booking system
    private bool IsPaid { get; set;}
    public Booking(Guest guest, Room room, IPayable paymentMethod, DateTime checkInDate, DateTime checkOutDate)
    {
        this.room = room;
        this.paymentMethod = paymentMethod;
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
        isPaid = false;
        bookingId = BookingIdGenerator.GenerateBookingId();
    }

    public string BookingId => BookingId;
    public Room Room => room;
    public Guest Guest => guest;
    public DateTime CheckInDate => checkInDate;
    public DateTime CheckOutDate => checkOutDate;
    new decimal CalculateTotalPrice()
    {
        decimal totalprice = room.PricePerNight * (CheckOutDate - CheckInDate).Days;
        decimal discount = Guest.GetDiscount(totalprice);
        return totalprice - discount;
        
    }
    
    new void CheckIn()
    {
    }

    new void CheckOut()
    {
    }



}
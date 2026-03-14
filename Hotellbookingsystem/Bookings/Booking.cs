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
    private string BookingId;
    private Room room { get; set; }
    private Guest Guest { get; }
    private DateTime CheckInDate;
    private DateTime CheckOutDate;
    private IPayable paymentMethod;
    //TODO check that this isn't able to change outside the booking system
    private bool IsPaid { get; set;}
    public Booking(Guest guest, Room room, IPayable paymentMethod, DateTime checkInDate, DateTime checkOutDate)
    {
        this.Guest = guest;
        this.room = room;
        this.paymentMethod = paymentMethod;
        this.CheckInDate = checkInDate;
        this.CheckOutDate = checkOutDate;
        IsPaid = false;
        BookingId = BookingIdGenerator.GenerateBookingId();
    }
    
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
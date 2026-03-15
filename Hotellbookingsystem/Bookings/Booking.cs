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
    private readonly string bookingId;
    private readonly Room room;
    private readonly Guest guest;
    private readonly DateTime checkInDate;
    private readonly DateTime checkOutDate;
    private readonly IPayable paymentMethod;
    private bool isPaid;
    public Booking(Guest guest, Room room, IPayable paymentMethod, DateTime checkInDate, DateTime checkOutDate)
    {
        this.guest = guest;
        this.room = room;
        this.paymentMethod = paymentMethod;
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
        isPaid = false;
        bookingId = BookingIdGenerator.GenerateBookingId();
    }

    // AI-help here as well
    public string BookingId => BookingId;
    public Room Room => room;
    public Guest Guest => guest;
    public DateTime CheckInDate => checkInDate;
    public DateTime CheckOutDate => checkOutDate;

    public bool IsPaid => IsPaid;
    public IPayable PaymentMethod => paymentMethod;
    //<summary
    // calculates total price of the booking after discount
    //</summary>
    public decimal CalculateTotalPrice()
    {
        var nights = (checkOutDate - checkInDate).Days;
        if (nights <= 0)
        {
            throw new AbandonedMutexException("Check out date must be before Check-in date.");
        }
        decimal basePrice = room.PricePerNight * nights;
        return guest.GetDiscount(basePrice);
    }

    public bool ProcessPayment()
    {
        decimal totalPrice = CalculateTotalPrice();
        var paid=  paymentMethod.ProcessPayment(totalPrice);
        if (paid)
        {
            isPaid = true;
        }
        return paid;
    }
    
    new void CheckIn()
    {
        if (!isPaid)
        {
            throw new InvalidOperationException("Booking must be paid before check-in.");
        }
        room.IsAvailable = false;
    }

    new void CheckOut()
    {
        room.IsAvailable = true;
    }
}
using Hotellbookingsystem.Bookings;
using Hotellbookingsystem.Utils;

namespace Hotellbookingsystem.Guests;
//<summary>
// Guest base class
//</summary>
public abstract class Guest
{
    private readonly string guestId;
    private string name; // needs valdidation in set
    private string email; // needs valdidation in set
    public List<Booking> ActiveBookings;

    public Guest(string name, string email)
    {
        guestId = GuestIdGenerator.GenerateGuestId(); //TODO fix generator here
        Name = name;
        Email = email;
        ActiveBookings = new List<Booking>();
    }
    
    public string Name 
    { 
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");
            name = value; 
        }
    }
    public string Email
    {
        get => email;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                throw new ArgumentException("Invalid email");
            email = value;
        }
    }
    public string GuestId => guestId;

    public List<Booking> ActiveBookings1 => ActiveBookings;

    public abstract decimal GetDiscount(decimal bacePrice);
}

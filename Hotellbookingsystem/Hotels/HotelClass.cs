
using Hotellbookingsystem.Bookings;
using Hotellbookingsystem.Guests;
using Hotellbookingsystem.Payments;
using Hotellbookingsystem.Rooms;

namespace Hotellbookingsystem.Hotels;

public class HotelClass
{
    private string hotelName;
    private List<Room> RoomRegister { get; set; }
    private List<Guest> GuestRegister { get; set; }
    private List<Booking> BookingHistory { get; set; }

    public HotelClass()
    {
        // Empty list of all rooms, guests, and bookings
        RoomRegister = new List<Room>();
        GuestRegister = new List<Guest>();
        BookingHistory = new List<Booking>();
    }

    //<summary>
    // Register guest
    //</summary>
    public void RegisterGuest(Guest guest)
    {
        if (GuestRegister.Any(g => g.Email == guest.Email))
        {
            throw new ArgumentException("Guest already registered");
        }

        GuestRegister.Add(guest);
    }

    //<summary>
    // Register room
    //</summary>
    public void RegisterRoom(Room room)
    {
        if (RoomRegister.Any(r => r.RoomNumber == room.RoomNumber))
        {
            throw new ArgumentException("Room already registered");
        }

        RoomRegister.Add(room);
    }

    //<summary>
    // Register booking
    //</summary>
    public void RegisterBooking(Booking booking)
    {
        BookingHistory.Add(booking);
    }
//TODO fix this issue
// MAJOR AI HELP ON THIS Method CODE.
    public void ShowAvailableRooms(DateTime checkIn, DateTime checkOut)
    {
        Console.WriteLine($"Available rooms ({checkIn:dd.MM.yyyy} - {checkOut:dd.MM.yyyy}");
        foreach (var room in RoomRegister)
        {
            bool hasOverlappingBooking = BookingHistory.Any(b =>
                b.Room.RoomNumber == room.RoomNumber &&
                b.CheckOutDate > checkIn &&
                b.CheckInDate < checkOut);
            if (room.IsAvailable && !hasOverlappingBooking)
            {
                room.DisplayRoomInfo();
            }
        }
    }
    
    // AI HELP with Linq method - transformed for loop to linq method.
    //<summary>
    // Check if Guest is registered
    //</summary>
    public bool IsGuestReal(string guestId)
    {
        return GuestRegister.Any(g => g.GuestId == guestId);
    }

    //<summary>
    // Check if Room is registered
    //</summary>
    public bool IsRoomReal(string roomNumber)
    {
        return RoomRegister.Any(r => r.RoomNumber == roomNumber);

    }
    // <summary>
    // Create booking
    // </summary>
    public void CreateBooking(string guestId, string roomNumber, DateTime checkInDate, DateTime checkOutDate,
        IPayable paymentMethod)
    {
        // Finds userid in the user register
        if (!IsGuestReal(guestId))
            throw new ArgumentException("Guest not found");

        // Finds roomid in the room register
        if (!IsRoomReal(roomNumber))
            throw new ArgumentException("Room not found");
        
        // verify checkin and checkout dates
        if (checkInDate > checkOutDate)
            throw new ArgumentException("Check-in date must be before check-out date");
        
        var guest = GuestRegister.FirstOrDefault(g => g.GuestId == guestId);
        var room = RoomRegister.FirstOrDefault(r => r.RoomNumber == roomNumber);
        
        // Check max bookings
        int isGuestBookingsMaxed = guest.ActiveBookings.Count;
        if (guest is RegularGuest && isGuestBookingsMaxed >= 3)
            throw new ArgumentException("Guest has reached maximum number of bookings");
        if (guest is VipGuest && isGuestBookingsMaxed >= 10)
            throw new ArgumentException("Vip guest has reached maximum number of bookings");
        
        // All is good
        // Create booking object
        var booking = new Booking(guest, room, paymentMethod, checkInDate, checkOutDate);
        // process payment
        if (!booking.ProcessPayment())
            throw new ArgumentException("Payment failed");
        // Create booking
        guest.ActiveBookings.Add(booking);
        // add booking to history
        RegisterBooking(booking);
        
        // add loyalty points for VIP's
        if (guest is VipGuest vipGuest)
        {
            vipGuest.AddLoyaltyPointsBooking();
        }

        // add messages for output
        //TODO FIX THIS SO THAT IT ACTUALLY WORKS
        Console.WriteLine($"Booking {booking.BookingId} created for {guest.Name} ({guest.GuestId})");
        Console.WriteLine($"{room.RoomType} ({room.RoomNumber} -- {checkInDate:dd.MM.yyyy}, {checkOutDate : dd.MM.yyyy}");
        Console.WriteLine($"Total Price: {booking.CalculateTotalPrice()} kr");
        Console.WriteLine($"Payment approved with: {paymentMethod.GetType().Name}");
    }
    
        //TODO Implement Get GUEST BOOKINGS for menu handler
        
        //TODO IMPLEMENT void CHECKIN for menu handler
        // AI HELP HERE, IDE
        public void CheckIn(string bookingId)
        {
            var booking = BookingHistory.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking == null)
                throw new ArgumentException("Booking not found");

            booking.CheckIn();
            Console.WriteLine($"{booking.Guest.Name} checked in for {booking.Room.RoomNumber}");
        }
        
        //TODO IMPLEMENT void CHECKOUT for menu handler
        
        // AI HELP HERE, IDE
        public void CheckOut(string bookingId)
        {
            var booking = BookingHistory.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking == null)
                throw new ArgumentException("Booking not found");

            booking.CheckOut();
            Console.WriteLine($"{booking.Guest.Name} checked out from {booking.Room.RoomNumber}");
        }
        
        
    }

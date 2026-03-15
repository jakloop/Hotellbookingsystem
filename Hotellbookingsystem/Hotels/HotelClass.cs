
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

    public void RegisterGuest(Guest guest)
    {
        if (GuestRegister.Any(g => g.Email == guest.Email))
        {
            throw new ArgumentException("Guest already registered");
        }

        GuestRegister.Add(guest);
    }

    public void RegisterRoom(Room room)
    {
        if (RoomRegister.Any(r => r.RoomNumber == room.RoomNumber))
        {
            throw new ArgumentException("Room already registered");
        }

        RoomRegister.Add(room);
    }

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

//TODO implement this?
    public bool IsGuestReal(string guestId)
    {
        Guest? guest = null;
        // Finds userid in the user register
        
        foreach (var g in GuestRegister)
            if (g.GuestId == guestId)
            {
                return true;
            }
        return false;
    }

    public bool IsRoomReal(string roomNumber)
    {
        Room? room = null;
        // Finds userid in the user register
        foreach (var r in RoomRegister)
            if (r.RoomNumber == roomNumber)
            {
                return true;
            }
        return false;
    }


    public void CreateBooking(string guestId, string roomNumber, DateTime checkInDate, DateTime checkOutDate,
        IPayable paymentMethod)
    //NEEDS TO BE IMPLENTED ASAP, 
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
        
        // verify if room is available
        Room? room = RoomRegister.FirstOrDefault(r => r.RoomNumber == roomNumber);
        
        // Check max bookings
        
        
        // Create booking
        
        // process payment
        
        // add booking to history
        
        // ad loyalty points for VIPS
        
        // add messages for output
    }
    
        
        //TODO Implement Get GUEST BOOKINGS for menu handler
        
        //TODO IMPLEMENT void CHECKIN for menu handler
        
        //TODO IMPLEMENT void CHECKOUT for menu handler
        
        
    }

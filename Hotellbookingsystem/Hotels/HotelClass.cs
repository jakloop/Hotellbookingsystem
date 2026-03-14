//bruker linq her
//TODO forklar linq her
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
    public string ShowAvailableRooms()
    {
        bool foundAvailableRoom = false;
        foreach (var room in RoomRegister)
            if (room.IsAvailable)
            {
                //Console.WriteLine($"{Room.DisplayRoomInfo()}");
                foundAvailableRoom = true;
            }

        if (!foundAvailableRoom)
            return "No available rooms";
        return "That's all.";
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
    
    
    public void CreateBooking(string guestId, string roomNumber, DateTime checkInDate, DateTime checkOutDate, IPayable iPayable)
    {
        Guest? guest = null;
        Room? room = null;
        
        // Finds userid in the user register
        if (!IsGuestReal(guestId))
            throw new ArgumentException("Guest not found");
        
        // Finds roomid in the room register
        if (!IsRoomReal(roomNumber))
            throw new ArgumentException("Room not found");
        
        //foreach (var g in GuestRegister)
        //    if (g.GuestId == guestId)
        //   {
        //        guest = g;
        //        break;
        //    }
        
        
        // if there is no match
        
        // if (guest == null)
        //    throw new ArgumentException("Guest not found");
        
        // Finds roomid in the room register
        // foreach (var r in RoomRegister)
        //    if (r.RoomNumber == roomNumber)
        //    {
        //        room = r;
        //        break;
        //    }

        //if (room == null)
        //    throw new ArgumentException("Room not found");
        
        // Checks if it is available
        if (!room.IsAvailable)
            throw new ArgumentException("Room is not available");
        
        // Update room availability
        room.IsAvailable = false;
        
        //TODO Impleament this
        // Create booking
        //Booking booking = new Booking(guest, room, checkInDate, checkOutDate,p );
        //RegisterBooking(booking);
        
        
    }
}
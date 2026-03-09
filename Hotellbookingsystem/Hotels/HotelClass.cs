//bruker linq her
//TODO forklar linq her
using System.Linq;
using Hotellbookingsystem.Bookings;
using Hotellbookingsystem.Guests;
using Hotellbookingsystem.Rooms;

namespace Hotellbookingsystem.Hotels;

public class HotelClass
{
    private string name;
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
    
    public string ShowAvailableRooms()
    {
        foreach(var room in RoomRegister)
            if (room.IsAvailable)
                Console.WriteLine($" Available: {room.RoomNumber}, {room.RoomType}, {room.PricePerNight}");
            else
                return "No available rooms";
        return "Returning to menu...";
    }
}
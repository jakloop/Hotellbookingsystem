using Hotellbookingsystem.Hotels;
using Hotellbookingsystem.Guests;
using Hotellbookingsystem.Utils;
using Hotellbookingsystem.Rooms;
using System;
using Hotellbookingsystem.Bookings;
using Hotellbookingsystem.Payments;
using Hotellbookingsystem.MenuHandlers;
namespace Hotellbookingsystem;

class Program
{
    static void Main(string[] args)
    {
        // Adding a hotel
        HotelClass hotel = new HotelClass();
        
        // Adding a couple of rooms
        Room room1 = new SingleRoom("Single", 800, true, 1);
        Room room2 = new DoubleRoom("Double", 1200, true, 2);
        hotel.RegisterRoom(room1);
        hotel.RegisterRoom(room2);
        
        // Adding a couple of guest
        Guest guest1 = new RegularGuest("John", "john@johnny.com");
        Guest guest2 = new VipGuest("Billy", "Billy@Billio.com");
        hotel.RegisterGuest(guest2);
        hotel.RegisterGuest(guest1);
        
        // Adding a couple of bookings
        // Booking booking1 = new Booking(guest1, room1, DateTime.Now, DateTime.Now.AddDays(1));
        // Booking booking2 = new Booking(guest2, room2, DateTime.Now, DateTime.Now.AddDays(2));
        // hotel.RegisterBooking(booking1);
        // hotel.RegisterBooking(booking2);
        
        Console.WriteLine(guest1.Name + " " + guest1.GuestId);
        Console.WriteLine(guest2.Name + " " + guest2.GuestId);
        Console.WriteLine(room1.RoomNumber + " " + room1.RoomType + " " + room1.PricePerNight);
        Console.WriteLine(room2.RoomNumber + " " + room2.RoomType + " " + room2.PricePerNight);
        
        Console.WriteLine("Starting program...");
        MenuHandler menuHandler = new MenuHandler(hotel);
        menuHandler.Menu();
    }
}
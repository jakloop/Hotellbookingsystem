using Hotellbookingsystem.Hotels;
using System;
using Hotellbookingsystem.Bookings;
using Hotellbookingsystem.Guests;
using Hotellbookingsystem.Rooms;
using Hotellbookingsystem.Payments;
using Hotellbookingsystem.Utils;


namespace Hotellbookingsystem.MenuHandlers;
//<summary>
// Menu handler class
// Allows navigation through console input
//</summary>
public class MenuHandler
{
    private HotelClass HotelClass;

    public MenuHandler(HotelClass hotel)
    {
        this.HotelClass = hotel;

    }

    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("\n === Hotel ====");
            Console.WriteLine("1. Show available rooms");
            Console.WriteLine("2. Create booking");
            Console.WriteLine("3. Check in");
            Console.WriteLine("4. Check out");
            Console.WriteLine("5. Show my bookings");
            Console.WriteLine("6. Register new guest");
            Console.WriteLine("0. Exit");
            Console.WriteLine("\nVelg alternativ: ");

            // User input, '?' can be none
            string? choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        HotelClass.ShowAvailableRooms();
                        break;
                    
                    case "2":
                        

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nTrykk Enter for å fortsette...");
        }


    }
}
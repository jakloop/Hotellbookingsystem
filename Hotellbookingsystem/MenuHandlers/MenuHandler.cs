using Hotellbookingsystem.Hotels;

namespace Hotellbookingsystem.MenuHandlers;
//<summary>
// Menu handler class
// Allows navigation through console input
//</summary>
public class MenuHandler
{
    public MenuHandler(HotelClass hotel)
    {
        this.hotel = hotel;
        
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
            Console.WriteLine("");
            
            // User input, ? can be none
            string? choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        
                }
            }
        }
        
    }
}
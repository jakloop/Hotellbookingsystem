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
    private HotelClass _hotelClass;

    public MenuHandler(HotelClass hotel)
    {
        this._hotelClass = hotel;

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
                        _hotelClass.ShowAvailableRooms();
                        break;
                    
                    case "2":
                        Console.WriteLine("Register new booking");
                        Console.WriteLine("Enter UserID");
                        string? userId = Console.ReadLine();
                        Console.WriteLine("Enter RoomID");
                        string? roomId = Console.ReadLine();
                        Console.WriteLine("Enter CheckInDate");
                        DateTime checkInDate = DateTime.TryParse(Console.ReadLine(), out DateTime date) ? date : DateTime.Now;
                        Console.WriteLine("Enter CheckOutDate");
                        DateTime checkOutDate = DateTime.TryParse(Console.ReadLine(), out date) ? date : DateTime.Now.AddDays(1);
                        Console.WriteLine("Enter PaymentMethod");
                        Console.WriteLine("1. Card payment");
                        Console.WriteLine("2. Vipps");
                        string? choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            case "1" :
                                Console.WriteLine("Card payment chosen");
                                Console.WriteLine("Enter 4 last digits in CardNumber");
                                string? cardNumber = (Console.ReadLine());
                                if CardPayment.IsExactlyFourDigitsInput(cardNumber)
                                    cardNumberinted = int.Parse(cardNumber);
                                
                                    
                                
                                
                                Console.WriteLine("Enter CardType");
                                string? cardType = Console.ReadLine();
                        }
                        
                        _hotelClass.CreateBooking(userId, roomId, checkInDate, checkOutDate, iPayable: new CardPayment() ? new VippsPayment());
                        break;
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
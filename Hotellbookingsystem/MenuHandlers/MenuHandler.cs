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
            Console.WriteLine("7. Cancel booking");
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
                        DateTime checkInDate = DateTime.TryParse(Console.ReadLine(), out DateTime date)
                            ? date
                            : DateTime.Now;

                        //TODO double check that this works v
                        Console.WriteLine("Enter CheckOutDate (dd.mm.yyyy):");
                        DateTime checkOutDate = DateTime.TryParse(Console.ReadLine(), out date)
                            ? date
                            : DateTime.Now.AddDays(1);

                        Console.WriteLine("Enter PaymentMethod");
                        Console.WriteLine("1. Card payment");
                        Console.WriteLine("2. Vipps");
                        string? choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            case "1":
                                Console.WriteLine("Card payment chosen");
                                Console.WriteLine("Enter 4 last digits in CardNumber: ");
                                // Enters card number
                                string? cardNumber = Console.ReadLine();

                                // verified if input is exactly 4 digits
                                // if CardPayment.IsExactlyFourDigitsInput(cardNumber)
                                // int cardNumberinted = int.Parse(cardNumber);


                                Console.WriteLine("Enter CardType");
                                string? cardType = Console.ReadLine();
                                break;
                        }

                        break;
                    //TODO implement this
                    //_hotelClass.CreateBooking(userId, roomId, checkInDate, checkOutDate, iPayable: new CardPayment(cardNumberInted) ? new VippsPayment());
                    //break;
                    case "3":
                        Console.WriteLine("Check in");
                        Console.WriteLine("Enter user Id");

                        break;
                    case "4":
                        Console.WriteLine("Check out");
                        Console.WriteLine("Enter user Id");
                        break;
                    case "5":
                        Console.WriteLine("Show my bookings");
                        Console.WriteLine("Enter user Id");
                        break;
                    case "6":
                        Console.WriteLine("Register new guest");
                        Console.WriteLine("Enter guest name");
                        string? guestName = Console.ReadLine();
                        Console.WriteLine("Enter guest email");
                        string? guestEmail = Console.ReadLine();
                        Console.WriteLine("Enter guest phone number");
                        string? guestPhoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter guest status, 1: regular, 2: vip");
                        string? guestStatus = Console.ReadLine();
                        break;
                    case "7. Cancel booking":
                        Console.WriteLine("Enter booking Id");
                        string? bookingId = Console.ReadLine();
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
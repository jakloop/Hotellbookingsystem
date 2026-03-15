using Hotellbookingsystem.Hotels;
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
                        Console.WriteLine("Show available rooms");
                        Console.WriteLine("Enter check in date (dd.mm.yyyy):");
                        DateTime checkIn = DateTime.TryParse(Console.ReadLine(), out DateTime date1)
                            ? date1
                            : DateTime.Now;
                        Console.WriteLine("Enter check out date (dd.mm.yyyy):");
                        DateTime checkOut= DateTime.TryParse(Console.ReadLine(), out DateTime date2)
                            ? date2
                            : DateTime.Now.AddDays(1);
                        _hotelClass.ShowAvailableRooms(checkIn, checkOut);
                        break;

                    case "2":
                        Console.WriteLine("Register new booking");
                        Console.WriteLine("Enter UserID");
                        string? userId = Console.ReadLine();
                        Console.WriteLine("Enter RoomID");
                        string? roomId = Console.ReadLine();
                        Console.WriteLine("Enter CheckInDate");
                        DateTime checkInDate = DateTime.TryParse(Console.ReadLine(), out DateTime date3)
                            ? date3
                            : DateTime.Now;

                        //TODO double check that this works v
                        Console.WriteLine("Enter CheckOutDate (dd.mm.yyyy):");
                        DateTime checkOutDate = DateTime.TryParse(Console.ReadLine(), out DateTime date4)
                            ? date4
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
                                _hotelClass.CreateBooking(userId, roomId, checkInDate, checkOutDate, new CardPayment(cardNumber, cardType));
                                break;
                            case "2":
                                Console.WriteLine("Vipps payment chosen");
                                Console.WriteLine("Enter Vipps number: ");
                                string? vippsNumber = Console.ReadLine();
                                _hotelClass.CreateBooking(userId, roomId, checkInDate, checkOutDate, new VippsPayment(vippsNumber));
                                break;
                            
                        }
                        break;
                    case "3":
                        Console.WriteLine("Check in");
                        Console.WriteLine("Enter booking Id:");
                        string bookingId2 = Console.ReadLine();
                        //TODO implement check in through hotel.class
                        _hotelClass.CheckIn(bookingId2);
                        break;
                   
                    // IDE AI HELP HERE, brain stopped functioning and Í tried
                    // to call Checkin through booking.
                    // IDE suggested the function in "hotel.class"
                    case "4":
                        Console.WriteLine("Check out");
                        Console.WriteLine("Enter booking Id");
                        string bookingId3 = Console.ReadLine();
                        //TODO implement check out through hotel.class
                        _hotelClass.CheckOut(bookingId3);
                        break;
                    
                    case "5":
                        Console.WriteLine("Show my bookings");
                        Console.WriteLine("Enter user Id");
                        //TODO implement showmybookings through hotel.class
                        
                        break;
                    case "6":
                        //TODO Implement register guest
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
                        // implement cancel booking through hotel.class
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
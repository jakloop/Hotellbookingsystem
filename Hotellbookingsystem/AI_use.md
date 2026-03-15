
# AI use

When I start projects like this I always try to limit the use of AI to the minimum. 
This is because I believe that there is much valuable learning in solving problems through 'doing it yourself'.
In spite of this, I also see the value of AI in some situations. Especially when I want to discuss different solutions
to a problem, or when I don't grasp the problem completely.

This project is similar to a previous project, where I built a library system. In that project I used AI
as a help for finding solutions to problems in my code, discussions, making templates I could be inspired by.
Much of the code in this project is based on the code from that project. This drastically reduced the need for help in 
general. I was able to solve problems much faster, and do I through the exeperience of the previous project.

## AI statement
In THIS project I have used AI (chatgpt or riderAIChat) in the following tasks.
- Help with Email check

This was assisted through the use of the AI in IDE (Rider).
Code before:
if (GuestRegister.Contains(guest.Email))
throw new ArgumentException("Guest already registered");
GuestRegister.Add(guest);

Code after AI guidance:

    public void RegisterGuest(Guest guest)
    {
        if (GuestRegister.Any(g => g.Email == guest.Email))
        {
            throw new ArgumentException("Guest already registered");
        }
        GuestRegister.Add(guest);
    }


- fixing Ipayment in createbooking() (RIDERAICHAT)
- I'm struggling to get the IPayment to work in the CreatBooking class, can you see whats wrong?
  
- Short answer:
  The main thing wrong with IPayable in CreateBooking is:
  IPayable is not public
  you pass IPayment as a parameter but use payment inside the method
  guest/room lookup can return null
  If you want, I can give you a fully corrected version of IPayable, CardPayment, VippsPayment, and CreateBooking together so they all line up cleanly.


- Credit card length validator
//
public class Validator
{
public static bool IsExactlyFourDigitsInput(string input)
{
// Trim whitespace first to handle inputs like " 1234 "
string trimmedInput = input.Trim();

        // Check if it's all digits and exactly 4 characters long
        bool isFourDigits = trimmedInput.All(char.IsDigit) && trimmedInput.Length == 4;
        
        return isFourDigits;
    }
}


- Helped with the available room check
//TODO implement this after you have checked the cange in comit.

- code after:
  public string ShowAvailableRooms()
  {
  bool foundAvailableRoom = false;

  foreach (var room in RoomRegister)
  {
  if (room.IsAvailable)
  {
  Console.WriteLine(room.DisplayRoomInfo());
  foundAvailableRoom = true;
  }
  }

  if (!foundAvailableRoom)
  return "No available rooms";

  return "Returning to menu...";
  }


#2Help on readonly fields on booking class - also discussion.

Prompts:
Inserted the code i had on booking class ( a lot of improvements were neccessary), and asked for help on the
fields, and properties.

public class Booking
{
private string BookingId;
private  Room room;
private  Guest { get; }
private  DateTime CheckInDate;
private reaDateTime CheckOutDate;
private IPayable paymentMethod;
//TODO check that this isn't able to change outside the booking system
private bool IsPaid { get; set;}
public Booking(Guest guest, Room room, IPayable paymentMethod, DateTime checkInDate, DateTime checkOutDate)
{
this.Guest = guest;
this.room = room;
this.paymentMethod = paymentMethod;
this.CheckInDate = checkInDate;
this.CheckOutDate = checkOutDate;
IsPaid = false;
BookingId = BookingIdGenerator.GenerateBookingId();
}

Code after AI help:
Improved version of the class
   Example refactored version:

public class Booking
{
private readonly string bookingId;
private readonly Room room;
private readonly Guest guest;
private readonly DateTime checkInDate;
private readonly DateTime checkOutDate;
private readonly IPayable paymentMethod;

    private bool isPaid;

    public Booking(Guest guest, Room room, IPayable paymentMethod,
                   DateTime checkInDate, DateTime checkOutDate)
    {
        this.guest = guest;
        this.room = room;
        this.paymentMethod = paymentMethod;
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;

        bookingId = BookingIdGenerator.GenerateBookingId();
        isPaid = false;
    }

    public string BookingId => bookingId;
    public Room Room => room;
    public Guest Guest => guest;
    public DateTime CheckInDate => checkInDate;
    public DateTime CheckOutDate => checkOutDate;
    public bool IsPaid => isPaid;



HELP FROM RIDER AI:
Input- help me implement the code on ShowavailableRooms() so that it uses
datetime checkin and chechout to find available rooms in a certain timeframe.
Use bookingHistory to check if a room is already booked in the time frame.

Code before RIDER AI:
    public void ShowAvailableRooms(DateTime checkIn, DateTime checkOut)
    {
         bool foundAvailableRoom = false;
         foreach (var room in RoomRegister)
            if (room.IsAvailable)
            {
                Console.WriteLine($"{room.DisplayRoomInfo()}");
                foundAvailableRoom = true;
            }

        if (!foundAvailableRoom)
            return "No available rooms";
        return "That's all.";

Code after RIDER AI:
public void GetAvailableRooms(DateTime checkIn, DateTime checkOut)
{
Console.WriteLine($"=== Available rooms ({checkIn:dd.MM.yyyy} - {checkOut:dd.MM.yyyy}) ===");

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
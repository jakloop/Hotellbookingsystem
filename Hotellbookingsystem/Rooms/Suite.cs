namespace Hotellbookingsystem.Rooms;
//<summary>
// Suite class
//<summary>
public class Suite : Room
{
    // HasJacuzzi (bool), max guests (1), standard price per night = 800
    private int maxGuests;
    private decimal standardPricePerNight;

    public Suite(string roomType, decimal pricePerNight, bool isAvailable, bool hasJacuzzi, bool hasLounge):
        base("Suite", 3500, isAvailable, 5)
    {
        HasJacuzzi = hasJacuzzi;
        HasLounge = hasLounge;
    }
    
    public bool HasJacuzzi { get; }
    public bool HasLounge { get; }
    
    public override void DisplayRoomInfo()
    {
        //throw new NotImplementedException();
        Console.WriteLine(
            $"[ {RoomNumber} ] {RoomType}  -  {PricePerNight} kr/night - Max {MaxGuests} guests  - Has desk: {(HasLounge ? "Yes" : "No")} Has desk: {{(HasJacuzzi ? \"Yes\" : \"No\")");
    }
}
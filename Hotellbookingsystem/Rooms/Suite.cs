namespace Hotellbookingsystem.Rooms;
//<summary>
// Suite class
//<summary>
public class Suite : Room
{
    // HasJacuzzi (bool), max guests (1), standard price per night = 800
    private bool hasJacuzzi;
    private int maxGuests;
    private decimal standardPricePerNight;
    public Suite(string roomType, decimal pricePerNight, bool isAvailable) :
        base("Suite", 3500, isAvailable, 5)
    {
    }
    public override void DisplayRoomInfo()
    {
        throw new NotImplementedException();
    }
}
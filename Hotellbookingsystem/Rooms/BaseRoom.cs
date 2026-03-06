namespace Hotellbookingsystem.Rooms;
//<summary>
// Base class for all rooms
//</summary>
public abstract class Room
{
    private string roomNumber;
    private string roomType;
    private decimal pricePerNight;
    private bool isAvailable;
    private int maxGuests;

    public abstract string DipsplayRoomInfo();
}
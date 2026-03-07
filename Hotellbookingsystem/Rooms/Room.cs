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
    
    public string RoomNumber { get; }
    public string RoomType { get; set; }
    public decimal PricePerNight { get; set; }
    public bool IsAvailable { get; set; }
    public int MaxGuests { get; set; }
    public abstract void DipsplayRoomInfo();
}
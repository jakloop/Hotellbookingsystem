namespace Hotellbookingsystem.Rooms;
//<summary>
// Base class for all rooms
//</summary>
public abstract class Room
{
    private string roomNumber;
    private string roomType;
    private decimal pricePerNight;
    public bool isAvailable;
    private int maxGuests;

    protected Room(string roomNumber, string roomType, decimal pricePerNight, bool isAvailable, int maxGuests)
    {
        RoomNumber = Guid.NewGuid().ToString(); //TODO fix generator here
        RoomType = roomType;
        PricePerNight = pricePerNight;
        // The room is available by default
        IsAvailable = true;
        MaxGuests = maxGuests;
    }
    public string RoomNumber { get; }
    public string RoomType { get; set; }
    public decimal PricePerNight
    {
        get => pricePerNight;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Price cannot be negative");
            pricePerNight = value;
        }
    public bool IsAvailable { get; set; }
    public int MaxGuests 
        { 
            get;
            // protected so it can only be set in the subclasses
            protected set;
        
        }
    public abstract void DipsplayRoomInfo();
}
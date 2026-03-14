using Hotellbookingsystem.Utils;


namespace Hotellbookingsystem.Rooms;
//<summary>
// Base class for all rooms
//</summary>
public abstract class Room
{
    
    protected Room(string roomType, decimal pricePerNight, bool isAvailable, int maxGuests)
    {
        RoomNumber = RoomIdGenerator.GenerateRoomNumber(); //TODO fix generator here
        RoomType = roomType;
        PricePerNight = pricePerNight;
        // The room is available by default
        IsAvailable = isAvailable;
        MaxGuests = maxGuests;
    }
    
    private decimal pricePerNight;
    public string RoomNumber { get; }
    public string RoomType { get; protected set; }

    public decimal PricePerNight
    {
        get => pricePerNight;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Price cannot be negative");
            pricePerNight = value;
        }
    }

    public bool IsAvailable { get; set; }
    public int MaxGuests 
        { 
            get;
            // protected so it can only be set in the subclasses
            protected set;
        
        }
    public abstract string DisplayRoomInfo();
}
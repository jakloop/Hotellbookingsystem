namespace Hotellbookingsystem.Rooms;
//<summary>
// Double room class
//</summary>
public class DoubleRoom : Room
{
    public DoubleRoom(string roomType, decimal pricePerNight, bool isAvailable, int maxGuests) :
        base("Double", 1200, isAvailable, 2)
    {
        MaxGuests = 2;
        PricePerNight = 1200;
        RoomType = "Double";
        
    }
    //TODO implement display room info()
    public override void DisplayRoomInfo()
    {
        throw new NotImplementedException();
    }
}
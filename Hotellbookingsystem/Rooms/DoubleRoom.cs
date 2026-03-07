namespace Hotellbookingsystem.Rooms;
//<summary>
// Double room class
//</summary>
public class DoubleRoom : Room
{
    public DoubleRoom(string roomNumber, string roomType, decimal pricePerNight, bool isAvailable, int maxGuests) :
        base(roomNumber, roomType, pricePerNight, isAvailable, maxGuests)
    {
        MaxGuests = 2;
        PricePerNight = 1200;
        RoomType = "Double";
        
    }
    //TODO implement display room info()
    public override void DipsplayRoomInfo()
    {
        return;
    }
}
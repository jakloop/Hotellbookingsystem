namespace Hotellbookingsystem.Rooms;
//<summary>
// Single room class
//</summary>
public class SingleRoom: Room
{
    private bool hasDesk;
    public SingleRoom(string RoomNumber, string RoomType, decimal PricePerNight, bool IsAvailable, int MaxGuests) :
        base(RoomNumber, RoomType, PricePerNight, IsAvailable, MaxGuests)
    {
        MaxGuests = 1;
        PricePerNight = 800;
        RoomType = "Single";
    }
    
    
    //TODO implement display room info()
    public override void DipsplayRoomInfo()
    {
        return;
    }

}
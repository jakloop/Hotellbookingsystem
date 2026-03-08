namespace Hotellbookingsystem.Rooms;
//<summary>
// Single room class
//</summary>
public class SingleRoom: Room
{
    private bool hasDesk;
    public SingleRoom(string RoomType, decimal PricePerNight, bool IsAvailable, int MaxGuests) :
        base("Single", 800, IsAvailable, 1)
    {
    }
    
    
    //TODO implement display room info()
    public override void DisplayRoomInfo()
    {
        throw new NotImplementedException();
    }

}
namespace Hotellbookingsystem.Rooms;
//<summary>
// Single room class
//</summary>
public class SingleRoom : Room
{
    public SingleRoom(string roomType, decimal pricePerNight, bool isAvailable, int maxGuests, bool hasDesk) :
        base("Single", 800, isAvailable, 1)
    {
        HasDesk = hasDesk;
    }
    public bool HasDesk { get; }

    public override string DisplayRoomInfo()
    {
        //throw new NotImplementedException();
        return $"[ {RoomNumber} ] {RoomType}  -  {PricePerNight} kr/night - Max {MaxGuests} guests  - Has desk: {(HasDesk ? "Yes" : "No")}";
    }
}

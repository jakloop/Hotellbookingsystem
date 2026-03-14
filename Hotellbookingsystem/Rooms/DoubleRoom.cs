namespace Hotellbookingsystem.Rooms;
//<summary>
// Double room class
//</summary>
public class DoubleRoom : Room
{

    public DoubleRoom(string roomType, decimal pricePerNight, bool isAvailable, int maxGuests, bool hasExtraBed) :
        base("Double", 1200, isAvailable, 2)
    {
        HasExtraBed = hasExtraBed;
    }
    public bool HasExtraBed { get; }
    public override void DisplayRoomInfo()
    {
        //throw new NotImplementedException();
        Console.WriteLine($"[ {RoomNumber} ] {RoomType}  -  {PricePerNight} kr/night - Max {MaxGuests} guests  - Has extra bed: {(HasExtraBed ? "Yes" : "No")}");
    }
}

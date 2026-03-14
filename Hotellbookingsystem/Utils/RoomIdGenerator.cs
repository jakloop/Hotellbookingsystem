namespace Hotellbookingsystem.Utils;
//<summary>
// Generates room numbers, incremanting by 1
//</summary>
public class RoomIdGenerator
{
    private static int roomCounter = 0;

    public static string GenerateRoomNumber()
    {
        roomCounter++;
        return $"{roomCounter:D3}";
    }
}
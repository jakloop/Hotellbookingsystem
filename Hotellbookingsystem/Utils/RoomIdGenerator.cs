namespace Hotellbookingsystem.Utils;
//<summary>
// Generates room numbers, incremanting by 1
//</summary>
public class RoomIdGenerator
{
    private static int roomCounter = 0;

    private static string RoomNumberGenerator()
    {
        roomCounter++;
        return $"{roomCounter:D3}";
    }
}
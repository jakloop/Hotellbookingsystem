namespace Hotellbookingsystem.Utils;

public class RoomGenerator
{
    private static int roomCounter = 0;

    private static string RoomNumberGenerator()
    {
        roomCounter++;
        return $"{roomCounter:D3}";
    }
}
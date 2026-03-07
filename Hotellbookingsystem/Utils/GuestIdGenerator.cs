namespace Hotellbookingsystem.Utils;
//<summary>
// Generates guest ids
//</summary>
public class GuestIdGenerator
{
    private static int guestCounter = 0;

    public static string GenerateGuestId()
    {
        guestCounter++;
        return $"G{guestCounter:D3}";
    }
}
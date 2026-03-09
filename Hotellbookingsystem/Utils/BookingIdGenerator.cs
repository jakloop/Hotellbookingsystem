namespace Hotellbookingsystem.Utils;

//<summary>
// Generates booking ids, ingcrementing by 1
//</summary>
public class BookingIdGenerator
{
    private static int bookingCounter = 0;
    public static string GenerateBookingId()
    {
        bookingCounter++;
        return $"BK{bookingCounter:D3}";
    }
}
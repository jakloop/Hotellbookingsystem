namespace Hotellbookingsystem.Utils;

//<summary>
// Generates booking ids
//</summary>
public class BookingIdGenerator
{
    private static int bookingCounter = 0;
    public static string GenerateBookingId()
    {
        bookingCounter++;
        return $"B{bookingCounter:D3}";
    }
}
namespace Hotellbookingsystem.Guests;
//<summary>
// Guest base class
//</summary>
public class Guest
{
    private string name;
    private string email; // need valdidation
    
    public string Name { get; set; }
    public string Email { get; set; }

    public string guestId { get; }
}

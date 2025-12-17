public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email)
        : base(title, description,date, time, address)
    {
        _email = email;
    }
    public new string FullDetails()
    {
        string details = base.GetDetails();
        details += $"\nRSVP Email: {_email}";
        return details;
    }
}
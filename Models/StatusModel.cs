using RentalTest.Interfaces;

public class StatusModel : IStatus
{
    public int StatusId { get; set; }
    public string Name { get; set; } = string.Empty;
}
using RentalTest.Interfaces;
using RentalTest.Models;

public class StatusModel : IStatus
{
    public int StatusId { get; set; }
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<EquipmentModel> Equipments { get; set; } = new List<EquipmentModel>();
}
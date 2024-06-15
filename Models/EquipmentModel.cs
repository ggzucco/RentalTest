using RentalTest.Interfaces;

namespace RentalTest.Models
{
    public class EquipmentModel : IEquipment
    {
        public int EquipmentId { get ; set ; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime LastMaintenanceDate { get; set; }
        public decimal RentalRate { get; set; }
        public IStatus Status { get; set; } = new StatusModel();
        public ICategory Category { get; set; } = new CategoryModel();
    }
}

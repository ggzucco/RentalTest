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

        public int CategoryId { get; set; }
        public int StatusId { get; set; }

        public StatusModel Status { get; set; } = new StatusModel();
        public CategoryModel Category { get; set; } = new CategoryModel();
    }
}

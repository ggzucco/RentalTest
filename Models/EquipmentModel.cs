using RentalTest.Interfaces;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        public StatusModel Status { get; set; } = new StatusModel();

        [JsonIgnore]
        public CategoryModel Category { get; set; } = new CategoryModel();
    }
}

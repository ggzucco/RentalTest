using RentalTest.Models;

namespace RentalTest.Interfaces
{
    public interface IEquipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public decimal RentalRate { get; set; }
        public int CategoryId { get; set; }
        public int StatusId { get; set; }
    }
}

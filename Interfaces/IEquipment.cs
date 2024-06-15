namespace RentalTest.Interfaces
{
    public interface IEquipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public decimal RentalRate { get; set; }

        public IStatus Status { get; set; }
        public ICategory Category { get; set;}
    }
}

using Microsoft.AspNetCore.Mvc;
using RentalTest.Models;
using RentalTest.Interfaces;

namespace RentalTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly ILogger<EquipmentController> _logger;

        public EquipmentController(ILogger<EquipmentController> logger)
        {
            _logger = logger;
        }     

        [HttpGet]
        public IEnumerable<IEquipment> Get()
        {
            return new List<IEquipment>
            {
                new EquipmentModel 
                { 
                    EquipmentId = 1, 
                    Name = "Excavator A", 
                    Location = "Mines", 
                    LastMaintenanceDate = DateTime.Now,
                    RentalRate = 10.00m,
                    Status = new StatusModel { StatusId = 1, Name = "Available" },
                    Category = new CategoryModel { CategoryId = 1, Name = "Excavator" }
                },
                new EquipmentModel
                {
                    EquipmentId = 2,
                    Name = "Excavator B",
                    Location = "Mines",
                    LastMaintenanceDate = DateTime.Now,
                    RentalRate = 10.00m,
                    Status = new StatusModel { StatusId = 1, Name = "Available" },
                    Category = new CategoryModel { CategoryId = 1, Name = "Excavator" }
                },
            };
        }

        [HttpGet("{id}")]
        public IEquipment Get(int id)
        {
            return new EquipmentModel
            {
                EquipmentId = 1,
                Name = "Excavator A",
                Location = "Mines",
                LastMaintenanceDate = DateTime.Now,
                RentalRate = 10.00m,
                Status = new StatusModel { StatusId = 1, Name = "Available" },
                Category = new CategoryModel { CategoryId = 1, Name = "Excavator" }
            };
        }
        
        [HttpPost]
        public IEquipment Post(IEquipment equipment)
        {
            return equipment;
        }
        
        [HttpPut("{id}")]
        public IEquipment Put(int id, IEquipment equipment)
        {
            return equipment;
        }
        
        [HttpDelete("{id}")]
        public IEquipment Delete(int id)
        {
            return new EquipmentModel();
        }    
    }
}

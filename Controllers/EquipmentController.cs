using Microsoft.AspNetCore.Mvc;
using RentalTest.Models;
using RentalTest.Interfaces;
using SQLitePCL;
using RentalTest.Context;
using Microsoft.EntityFrameworkCore;

namespace RentalTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly ILogger<EquipmentController> _logger;
        private readonly RentalContext _context;
        public EquipmentController(ILogger<EquipmentController> logger, RentalContext context)
        {
            _logger = logger;
            _context = context;
        }     

        [HttpGet]
        public IEnumerable<EquipmentModel> GetAll()
        {
            return _context.Equipment.ToList();           
        }

        [HttpGet("{id}")]
        public async Task<EquipmentModel> Get(int id)
        {
            return await _context.Equipment.FindAsync(id);
        }
        
        [HttpPost]
        public async Task<ActionResult<EquipmentModel>> Post(EquipmentModel equipment)
        {
            _context.Equipment.Add(equipment);
            await _context.SaveChangesAsync();

            return Ok(equipment);           
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult<EquipmentModel>> Put(int id, EquipmentModel equipment)
        {
            if (id != equipment.EquipmentId)
            {
                return BadRequest();
            }

            _context.Entry(equipment).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok();
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var equipment = await _context.Equipment.FindAsync(id);
            if (equipment == null)
            {
                return NotFound();
            }

            _context.Equipment.Remove(equipment);
            await _context.SaveChangesAsync();

            return Ok();
        }    
    }
}

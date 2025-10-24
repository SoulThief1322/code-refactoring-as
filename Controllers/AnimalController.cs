using CodeRefactoring.Data.Models;
using CodeRefactoring.Models;
using Microsoft.AspNetCore.Mvc;
using CodeRefactoring.Data;
using CodeRefactoring.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CodeRefactoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase
    {
        private ApplicationDbContext _context;
        private AnimalService servicer;

        public AnimalController(ApplicationDbContext context, AnimalService service)
        {
            _context = context;
            servicer = service;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllAnimals()
        {
            var animals = _context.Animals.ToList();
            if(animals == null || animals.Count == 0)
            {
                return NotFound("No animals found.");
            }
            return Ok(animals);
        }

        [HttpGet("getone/{x}")]
        public async Task<IActionResult> GetOneAnimal(int id)
        {
            var animal = await _context.Animals.FindAsync(id);

            if (animal == null)
            {
                return NotFound("Animal not found.");
            }

            var animalDetails = new AnimalDetails
            {
                Id = animal.Id,
                Name = animal.Name,
                Owner = animal.Owner,
                OwnerId = animal.OwnerId,
                Age = animal.Age,
                AnimalType = animal.Type,
                IsSick = animal.IsSick,
                Notes = animal.Notes
            };

            return Ok(animalDetails);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddAnimal([FromQuery] string name, User owner, int age, string type)
        {
            try
            {
                servicer.AddNewAnimal(name, owner, age, type);
                await _context.SaveChangesAsync();
                return Ok("Animal added successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error adding animal: {ex.Message}");
            }
        }

        [HttpPost("heal/{id}")]
        public async Task<IActionResult> HealAnimal(int id)
        {
            try
            {
                servicer.DoHeal(id);
                await _context.SaveChangesAsync();
                return Ok("Animal is healed... maybe.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error healing animal: {ex.Message}");
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var animal = _context.Animals.Find(id);
            try
            {
                if (animal == null)
                {
                    return NotFound("Animal not found.");
                }
                _context.Animals.Remove(animal);
                await _context.SaveChangesAsync();
                return Ok("Animal deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error deleting animal: {ex.Message}");
            }

        }

        [HttpPost("ageup")]
        public async Task<IActionResult> AgeUp()
        {
            try
            {
                servicer.RandomAgeUp();
                await _context.SaveChangesAsync();
                return Ok("Everyone got older.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error aging up animals: {ex.Message}");
            }
        }
    }
}

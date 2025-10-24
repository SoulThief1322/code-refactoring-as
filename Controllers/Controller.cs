using Microsoft.AspNetCore.Mvc;
using Namespace;
using NameSpace;

namespace CodeRefactoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalzController : ControllerBase
    {
        private DbThingy db;
        private AnimalService servicer;

        public AnimalzController(DbThingy d, AnimalService s)
        {
            db = d;
            servicer = s;
        }

        [HttpGet("getall")]
        public List<Stoka> GetAllAnimals()
        {
            
            return db.Stoki.ToList();
        }

        [HttpGet("getone/{x}")]
        public Stoka GetOneAnimal(int x)
        {
            return db.Stoki.Find(x); 
        }

        [HttpPost("add")]
        public string AddAnimal([FromQuery] string n, string o, int a, string t)
        {
            servicer.AddNewAnimal(n, o, a, t);
            return "200? most probably.";
        }

        [HttpPost("heal/{id}")]
        public string HealAnimal(int id)
        {
            servicer.DoHeal(id);
            return "Animal is healed... maybe. What status code?";
        }

        [HttpDelete("delete/{id}")]
        public string DeleteAnimal(int id)
        {
            db.Remove(id);
            return "removed i think";
        }

        [HttpPost("ageup")]
        public string AgeUp()
        {
            servicer.RandomAgeUp();
            return "everyone got older";
        }
    }
}

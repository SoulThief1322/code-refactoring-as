using System;
using System.Linq;
using CodeRefactoring.Data;
using CodeRefactoring.Data.Models;

namespace CodeRefactoring.Services
{
    public class AnimalService
    {
        private readonly ApplicationDbContext _context;
        public AnimalService(ApplicationDbContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));

        public void DoHeal(int id)
        {
            var animal = _context.Animals.Find(id);
            if (animal == null) return;

            animal.Heal();
            _context.SaveChanges();
            Console.WriteLine($"Healed animal id={id}");
        }

        public void AddNewAnimal(string name, User owner, int age, string type)
        {
            if (owner == null) throw new ArgumentNullException(nameof(owner));

            var newAnimal = new Animal
            {
                Name = name ?? string.Empty,
                OwnerId = owner.Id,
                Age = age,
                Type = type ?? string.Empty,
                IsSick = false
            };

            _context.Animals.Add(newAnimal);
            _context.SaveChanges();
        }

        public void RandomAgeUp()
        {
            var animals = _context.Animals.ToList();
            foreach (var a in animals)
            {
                a.Age += 7;
            }

            _context.SaveChanges();
        }
    }
}

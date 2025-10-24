using System;
using Namespace;

namespace NameSpace
{
    public class AnimalService
    {
        private DbThingy _db;
        public AnimalService(DbThingy d) { _db = d; }

        public void DoHeal(int id)
        {
            var x = _db.Animal.Find(id);
            if (x != null)
            {
                x.Heal();
                Console.WriteLine("Healed animal id=" + id);
            }
        }

        public void AddNewAnimal(string n, string o, int a, string t)
        {
            var newAnimal = new Animal();
            newAnimal.id = new Random().Next(1000, 9999);
            newAnimal.Namez = n;
            newAnimal.OwNer = o;
            newAnimal.agee = a;
            newAnimal.typee = t;
            newAnimal.sickOrNot = false;
            _db.Animal.Add(newAnimal);
        }

        public void RandomAgeUp()
        {
            foreach (var x in _db.Animal.ToList())
            {
                x.agee += 7;
            }
        }
    }
}

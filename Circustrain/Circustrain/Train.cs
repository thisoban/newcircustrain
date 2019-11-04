using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Train
    {
        private readonly List<Wagon> _wagons;
        //private List<Animal> _sortedlist;

        public Train(List<Animal> perronanimals)
        {
            //SortingAnimals(perronanimals);
            _wagons = new List<Wagon>();
            PlaceAnimals(perronanimals);
        }

        //geef param met dieren
        private void PlaceAnimals(List<Animal>anmialsperron)
        {
            List<Animal> animals = new List<Animal>();
            //sorteren
            animals = anmialsperron.OrderBy(a => a.Diet).ThenByDescending(a => a.Weight).ThenBy(a => a.Diet == Diet.herbivoor).Reverse().ToList();
            
            foreach (Animal animal in animals)
            {
                if (WagonAvailable(animal) == false)
                {
                    AddWagonToList(animal);
                }
            }
        }

        private bool WagonAvailable(Animal animal)
        {
            if (_wagons.Count > 0)
                foreach (Wagon wagon in _wagons)
                {
                    {
                        wagon.AnimalsChecker(animal);
                        return true;
                    }
                }
            AddWagonToList(animal);
            return false;
        }
        private void AddWagonToList(Animal animal)
        {
            _wagons.Add(new Wagon(animal));
        }
    }
}

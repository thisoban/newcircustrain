using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Train
    {
        private List<Wagon> _wagons;
        //private List<Animal> _sortedlist;

        public Train(List<Animal> perronanimals)
        {
            //SortingAnimals(perronanimals);
            _wagons = new List<Wagon>();


        }

       

        public bool WagonAvailable(Animal animal)
        {
            if (_wagons.Count > 0)
            {
                foreach (Wagon wagon in _wagons)
                {
                        wagon.AnimalsChecker(animal);
                        return true;
                }
            }
            return false;
        }
        public void AddWagonToList(Animal animal)
        {
            _wagons.Add(new Wagon(animal));
        }

        List<Animal> animals = new List<Animal>();
        public void SortingAnimals(List<Animal> animalsperron)
        {
            animals = animalsperron.OrderBy(a => a.Diet).ThenByDescending(a => a.Weight).ThenBy(a => a.Diet == Diet.herbivoor).Reverse().ToList();
        }

        //geef param met dieren
        public void PlaceAnimal()
        {
            //sorteren
            foreach (Animal animal in animals)
            {
                if (WagonAvailable(animal) == false)
                {
                    AddWagonToList(animal);
                }
            }
        }
    }
}

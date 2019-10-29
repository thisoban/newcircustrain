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
        private List<Animal> _sortedlist;

        public Train(List<Animal> perronanimals)
        {
            SortingAnimals(perronanimals);
            _wagons = new List<Wagon>();


        }

        public void SortingAnimals(List<Animal> animalsperron)
        {  //sortedlist problem everyting carnivoor 
            _sortedlist = animalsperron.OrderBy(a => a.Diet).ToList();
                //.ThenBy(a => a.Weight)
        }

        public bool WagonAvailable(Animal animal)
        {
            if (_wagons.Count > 0)
            {
                foreach (Wagon wagon in _wagons)
                {
                    if (wagon.Capacity < 10)
                    {
                        Wagon wagon1 = new Wagon();
                        wagon1.AnimalsChecker(animal);
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
        public void AddWagonToList(Animal animal)
        {
            _wagons.Add(new Wagon(animal));
        }
        public void PlaceAnimal()
        {
            foreach (Animal animal in _sortedlist)
            {
                if (WagonAvailable(animal) == false)
                {
                    AddWagonToList(animal);
                }
            }
        }
    }
}

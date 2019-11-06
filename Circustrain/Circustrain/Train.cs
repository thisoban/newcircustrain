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
            _wagons = new List<Wagon>();
            PlaceAnimals(perronanimals);
        }
        public Train(){

        }
        public void SortAnimals(List<Animal> animalsperron)
        {
            List<Animal> animals = animalsperron.OrderBy(a => a.Diet).ThenByDescending(a => a.Weight).ThenBy(a => a.Diet == Diet.herbivoor).ToList();
        }

        //geef param met dieren
        public void PlaceAnimals(List<Animal>animalsperron)
        {
            List<Animal> animals = animalsperron.OrderBy(a => a.Diet).ThenByDescending(a => a.Weight).ThenBy(a => a.Diet == Diet.herbivoor).ToList();

            //sorteren
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
                        wagon.AnimalsChecker(animal);
                        return true;
                    
                }
            return false;
        }
        private void AddWagonToList(Animal animal)
        {
            _wagons.Add(new Wagon(animal));
        }
    }
}

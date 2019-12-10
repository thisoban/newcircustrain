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
        public IEnumerable<Wagon> Wagons { get { return _wagons; } }
        public Train()
        {
            _wagons = new List<Wagon>();
        }
        public void SortAnimals(List<Animal> animalsPerron)
        {
            List<Animal> CarnivoorAnimals = animalsPerron.Where(s => s.Diet == Diet.Carnivoor).ToList();
            List<Animal> HerbivoorAnimals = animalsPerron.Where(s => s.Diet == Diet.Herbivoor).ToList();
            DistrubateAnimals(CarnivoorAnimals);
            DistrubateAnimals(HerbivoorAnimals);
        }
        public void DistrubateAnimals(List<Animal>animalsperron)
        {
          
            foreach (Animal animal in animalsperron)
            {
                if (animal.Diet == Diet.Carnivoor)
                {
                    AddAnimalToNewWagon(animal);
                }
                else
                {
                    if (IsThereSpaceInAnyWagons(animal) == false)
                    {
                        AddAnimalToNewWagon(animal);
                    }
                }
            }
        }
       
        private bool IsThereSpaceInAnyWagons(Animal animal)
        {
            if (_wagons.Count > 0)
            {
                foreach (Wagon wagon in _wagons)
                {
                    if(wagon.CheckIfAnimalFits(animal)==true)
                    return true;
                }
            }
            return false;
        }
        private void AddWagon(Wagon wagon)
        {
            _wagons.Add(wagon);
        }
        private void AddAnimalToNewWagon(Animal animal)
        {
            Wagon wagon = new Wagon(animal);
            AddWagon(wagon);
        }
    }
}

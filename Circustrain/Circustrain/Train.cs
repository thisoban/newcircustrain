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
        public void SortAnimals(List<Animal> animalsperron)
        {
            List<Animal> CarnivoorAnimals = animalsperron.Where(s => s.Diet == Diet.Carnivoor).ToList();
            List<Animal> HerbivoorAnimals = animalsperron.Where(s => s.Diet == Diet.Herbivoor).ToList();
            DistrubateAnimal(CarnivoorAnimals);
            DistrubateAnimal(HerbivoorAnimals);
        }
        public bool DistrubateAnimal(List<Animal>animalsperron)
        {
           // List<Animal> animals = animalsperron.OrderBy(a => a.Diet).ThenByDescending(a => a.Weight).ToList();

            //sorteren
            foreach (Animal animal in animalsperron)
            {
                if (animal.Diet == Diet.Carnivoor)
                {
                    AddAnimalToWagon(animal);
                }
                else
                {
                    if (IsthereSpaceInAnyWagons(animal) == false)
                    {
                        AddAnimalToWagon(animal);
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }
       
        private bool IsthereSpaceInAnyWagons(Animal animal)
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
        private void AddWagonToList(Wagon wagon)
        {
            _wagons.Add(wagon);
        }
        private void AddAnimalToWagon(Animal animal)
        {
            Wagon wagon = new Wagon(animal);
            AddWagonToList(wagon);
        }
    }
}

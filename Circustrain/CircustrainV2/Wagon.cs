using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CircustrainV2
{
   public class Wagon
   {
       private readonly List<Animal> _animalsinwagon;
       private const int _maxCapacity = 10;
       private Animal _biggestCarnivore;
       private Animal _biggestHerbivore;
       public IEnumerable<Animal> Animals => _animalsinwagon;

       public Wagon()
       {
           _animalsinwagon = new List<Animal>();
       }

       public bool CanAnimalBePlaced(Animal animal)
       {
           return IsSpaceAvailable(animal) && WontBeEaten(animal);
       }

       private bool IsSpaceAvailable(Animal animal)
       {
           return _animalsinwagon.Sum(a => a.Weight) + animal.Weight <= _maxCapacity;
       }

       private bool WontBeEaten(Animal animal)
       {
           if (animal.Diet == Diet.Carnivore)
               return _biggestCarnivore == null
                      && (_biggestHerbivore == null || _biggestHerbivore.Weight > animal.Weight);
           if (animal.Diet == Diet.Herbivore)
               return _biggestCarnivore == null
                      || _biggestCarnivore.Weight < animal.Weight;

           return false;
       }

       public void PlaceAnimal(Animal animal)
       {
           if (CanAnimalBePlaced(animal))
           {
               if (animal.Diet == Diet.Carnivore &&
                   (_biggestCarnivore == null || animal.Weight >= _biggestCarnivore.Weight))
                   _biggestCarnivore = animal;
               else if (animal.Diet == Diet.Herbivore &&
                        (_biggestHerbivore == null || animal.Weight >= _biggestHerbivore.Weight))
                   _biggestHerbivore = animal;
               _animalsinwagon.Add(animal);
           }
       }
   }
   
}

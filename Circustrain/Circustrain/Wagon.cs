using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Wagon
    {
        private readonly List<Animal> _animalsinwagon;
        public IEnumerable<Animal> Animals { get { return _animalsinwagon; } }

        public Wagon(Animal animal)
        {
            _animalsinwagon = new List<Animal>();
            _animalsinwagon.Add(animal);
        }
        public Wagon()
        {

        }

        public bool IsWagonAnimalCarnivore()
        {
            foreach(Animal wagonAnimal in _animalsinwagon)
            {
                if (wagonAnimal.Diet == Diet.Carnivoor)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckIfAnimalFits(Animal newAnimal)
        {
            //checks: does it fit  AND DoesAnimalGetEaten
            foreach (Animal wagonAnimal in _animalsinwagon)
            {
                if (wagonAnimal.Diet == Diet.Carnivoor)
                {
                    //gaat daarna vergelijken of current dier groter is dan carnivoor
                    if (wagonAnimal.HerbivoreBiggerThenCarnivore(wagonAnimal, newAnimal) == true)
                    {
                        if (DoesAnimalWeightFit(newAnimal) == true)
                        {
                            PlaceAnimal(newAnimal);
                            return true;
                        }
                       return false;
                    }
                }
             
                if (DoesAnimalWeightFit(newAnimal))
                {
                    PlaceAnimal(newAnimal);
                    return true;  
                }
                return false;
            }
            return false;
        }

        private void PlaceAnimal(Animal newAnimal)
        { 
            _animalsinwagon.Add(newAnimal);
        }


        private bool DoesAnimalWeightFit(Animal ianimal)
        {
            int totalweight = 0;

            foreach (Animal animal in _animalsinwagon)
            {
                totalweight += animal.Weight;
            }

            if (totalweight + ianimal.Weight <= 10) return true;
            return false;
        }
    }
}

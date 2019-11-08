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
            PLacingAnimal(animal);
        }

        public bool IsWagonAnimalCarnivore()
        {
            foreach(Animal wagonAnimal in _animalsinwagon)
            {
                if (wagonAnimal.Diet == Diet.carnivoor)
                {
                    return false;
                }
            }
            return true;
        }

        public void CheckingAnimalFit(Animal newAnimal)
        {
            //checks: does it fit  AND DoesAnimalGetEaten
            foreach (Animal wagonAnimal in _animalsinwagon)
            {
               
                if (wagonAnimal.Diet == Diet.carnivoor)
                {
                    //gaat daarna vergelijken of current dier groter is dan carnivoor
                    if (HerbivoreBiggerThenCarnivore(wagonAnimal, newAnimal))
                    {
                        if (DoesTheWeightFit(newAnimal))
                        {
                            PLacingAnimal(newAnimal);
                            break;
                        }
                    }
                }
             
                if (DoesTheWeightFit(newAnimal))
                {
                    PLacingAnimal(newAnimal);
                    break;
                }
            }
        }

        private void PLacingAnimal(Animal newAnimal)
        { 
            _animalsinwagon.Add(newAnimal);
        }

        private bool HerbivoreBiggerThenCarnivore(Animal wagonanimal, Animal animal)
        {
            if (wagonanimal.Weight <= animal.Weight) return true;
            return false;
        }

        private bool DoesTheWeightFit(Animal ianimal)
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

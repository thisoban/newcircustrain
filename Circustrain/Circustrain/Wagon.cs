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
            PlaceAnimal(animal);
        }
        public Wagon()
        {
            _animalsinwagon = new List<Animal>();
        }

        //public bool IsWagonAnimalCarnivore()
        //{
        //    foreach(Animal wagonAnimal in _animalsinwagon)
        //    {
        //        if (wagonAnimal.Diet == Diet.Carnivoor)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        public bool CheckIfAnimalFits(Animal newAnimal)
        {

            if (_animalsinwagon.Count == 0)
            {
                return true;
            }

            bool approved = true;
            
            foreach (Animal wagonAnimal in _animalsinwagon)
            {
                if (wagonAnimal.Diet == Diet.Carnivoor)
                {
                    if (wagonAnimal.IsHerbivoreBiggerThenCarnivore(newAnimal) == true)
                    {
                        if (DoesAnimalWeightFit(newAnimal) == true)
                        {
                            return true;
                        }
                        return false;
                    }
                    return false;
                }
                else if (DoesAnimalWeightFit(newAnimal))
                {
                    return true;  
                }
                return false;
            }

            return false;
        }

        public void PlaceAnimal(Animal newAnimal)
        {
            if(CheckIfAnimalFits(newAnimal) == true)
            {
                _animalsinwagon.Add(newAnimal);
            }
        }


        private bool DoesAnimalWeightFit(Animal newAnimal)
        {
            int totalWeight = 0;

            foreach (Animal animal in _animalsinwagon)
            {
                totalWeight += animal.Weight;
            }

            if (totalWeight + newAnimal.Weight <= 10) return true;
            return false;
        }
    }
}

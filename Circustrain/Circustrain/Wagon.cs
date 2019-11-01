using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Wagon
    {
        public int AnimalsWeightInWagon { get; set; }

        private readonly List<Animal> Animalsinwagon;
        public Wagon(Animal animal)
        {
            AnimalsWeightInWagon = 0;
            Animalsinwagon = new List<Animal>();
            PLaceAnimal(animal);
        }
        public Wagon()
        {

        }

        public void PLaceAnimal(Animal newAnimal)
        {
            Animalsinwagon.Add(newAnimal);
            AnimalsWeightInWagon += newAnimal.Weight;
        }

        public void AnimalsChecker(Animal newAnimal)
        {
            foreach (Animal wagonAnimal in Animalsinwagon)
            {
                if (newAnimal.Diet == Diet.carnivoor)
                {
                    break;
                }
                if (wagonAnimal.Diet == Diet.carnivoor)
                {
                    //gaat daarna vergelijken of current dier groter is dan carnivoor
                    if (HerbioreBiggerThenCarnivore(wagonAnimal, newAnimal))
                    {
                        if (DoesTheWeightFit(newAnimal))
                        {
                            PLaceAnimal(newAnimal);
                            break;
                        }
                    }
                }
             
                if (DoesTheWeightFit(newAnimal))
                {
                    PLaceAnimal(newAnimal);
                    break;
                }
            }
        }

        private bool HerbioreBiggerThenCarnivore(Animal wagonanimal, Animal animal)
        {
            if (wagonanimal.Weight <= animal.Weight) return true;
            return false;
        }

        private bool DoesTheWeightFit(Animal ianimal)
        {
            if (AnimalsWeightInWagon + ianimal.Weight <= 10) return true;
            return false;
        }
    }
}

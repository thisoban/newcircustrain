﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Wagon
    {
        public int Capacity { get; set; }

        private List<Animal> Animalsinwagon;
        public Wagon(Animal animal)
        {
            Capacity = 0;
            Animalsinwagon = new List<Animal>();
            PLaceAnimal(animal);
        }
        public Wagon()
        {

        }

        public void PLaceAnimal(Animal newAnimal)
        {
            Animalsinwagon.Add(newAnimal);
            Capacity += newAnimal.Weight;
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
                    if (SizeChecker(wagonAnimal, newAnimal))
                    {
                        if (CapacityCheck(newAnimal))
                        {
                            PLaceAnimal(newAnimal);
                            break;
                        }
                    }
                }
             
                if (CapacityCheck(newAnimal))
                {
                    PLaceAnimal(newAnimal);
                    break;
                }
            }
        }

        private bool SizeChecker(Animal wagonanimal, Animal animal)
        {
            if (wagonanimal.Weight <= animal.Weight) return true;
            return false;
        }

        private bool CapacityCheck(Animal ianimal)
        {
            if (Capacity + ianimal.Weight <= 10) return true;
            return false;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Train
    {
        private List<Wagon> _wagons;
        //private List<Animal> _sortedlist;

        public Train(List<Animal> perronanimals)
        {
            //SortingAnimals(perronanimals);
            _wagons = new List<Wagon>();


        }

        public void SortingAnimals(List<Animal> animalsperron)
        {  //sortedlist problem everyting carnivoor 
            _sortedlist = animalsperron.OrderBy(a => a.Diet).ThenByDescending(a => a.Weight).ThenBy(a => a.Diet == Diet.herbivoor).Reverse().ToList();
        }

        public bool WagonAvailable(Animal animal)
        {
            if (_wagons.Count > 0)
            {
                foreach (Wagon wagon in _wagons)
                {
                    if (wagon.AnimalsWeightInWagon < 10)
                    {
                        //Wagon wagon1 = new Wagon();
                        wagon.AnimalsChecker(animal);
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

        //geef pARAM MET DIEREN
        public void PlaceAnimal()
        {
            //sorteren
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

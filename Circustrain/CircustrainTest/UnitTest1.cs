using circustrein;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CircustrainTest
{
    public class Tests
    {
    

        [Test]
        public void OneSmallCarnivoorRestHerbivoor()
        {
            Train train = new Train();
            Animal animal1 = new Animal(1, Diet.Carnivoor);
            Animal animal2 = new Animal(5, Diet.Herbivoor);
            Animal animal3 = new Animal(5, Diet.Herbivoor);

            Animal animal4 = new Animal(3, Diet.Herbivoor);
            Animal animal5 = new Animal(3, Diet.Herbivoor);
            Animal animal6 = new Animal(3, Diet.Herbivoor);
            List<Animal> animalsstation = new List<Animal>
            {
                animal6,
                animal4,
                animal3,
                animal2,
                animal1,
                animal5
            };

            train.SortAnimals(animalsstation);
            Assert.AreEqual(2, train.Wagons.Count());
        }

        [Test]
        public void BigCarnivoorRestHerbivoor()
        {
            Train train = new Train();
            //dit kan ik ook in een lijst 
            Animal animal1 = new Animal(5, Diet.Carnivoor);
            Animal animal2 = new Animal(5, Diet.Herbivoor);
            Animal animal3 = new Animal(5, Diet.Herbivoor);

            Animal animal4 = new Animal(3, Diet.Herbivoor);
            Animal animal5 = new Animal(3, Diet.Herbivoor);
            Animal animal6 = new Animal(3, Diet.Herbivoor);
            List<Animal> animalsstation = new List<Animal>
            {
                animal6,
                animal4,
                animal3,
                animal2,
                animal1,
                animal5
            };

            train.SortAnimals(animalsstation);
            Assert.AreEqual(4, train.Wagons.Count());
        }
        [Test]
        public void TwoBigCarnivoorRestHerbivoor()
        {
            Train train = new Train();

            Animal animal1 = new Animal(5, Diet.Carnivoor);
            Animal animal2 = new Animal(5, Diet.Carnivoor);
            Animal animal3 = new Animal(5, Diet.Herbivoor);

            Animal animal4 = new Animal(5, Diet.Herbivoor);
            Animal animal5 = new Animal(5, Diet.Herbivoor);
            Animal animal6 = new Animal(5, Diet.Herbivoor);
            List<Animal> animalsstation = new List<Animal>
            {
                animal1,
                animal2,
                animal3,
                animal4,
                animal5,
                animal6
            };

            train.SortAnimals(animalsstation);
            Assert.AreEqual(3, train.Wagons.Count());
        }

        [Test]
        public void SmallCarnivoorBigHerbivoorInOneWagon()
        {
            Wagon wagon = new Wagon();

            Animal animal1 = new Animal(1, Diet.Carnivoor);
            Animal animal2 = new Animal(5, Diet.Carnivoor);
            wagon.CheckIfAnimalFits(animal1);
            Assert.IsTrue(wagon.CheckIfAnimalFits(animal2));
            
        }
        [Test]
        public void MediumCarnivoorBigHerbivoorInOneWagon()
        {
            Wagon wagon = new Wagon();

            Animal animal1 = new Animal(3, Diet.Carnivoor);
            Animal animal2 = new Animal(5, Diet.Carnivoor);
            wagon.CheckIfAnimalFits(animal1);
            Assert.IsFalse(wagon.CheckIfAnimalFits(animal2));
            
        }
        [Test]
        public void BigCarnivoorBigCarnivoorInOneWagon()
        {
            Wagon wagon = new Wagon();

            Animal animal1 = new Animal(5, Diet.Carnivoor);
            Animal animal2 = new Animal(5, Diet.Carnivoor);
            wagon.CheckIfAnimalFits(animal1);
            Assert.IsFalse(wagon.CheckIfAnimalFits(animal2));
            
        }
        [Test]
        public void BigCarnivoorSmallHerbivoorInOneWagon()
        {
            Wagon wagon = new Wagon();

            Animal animal1 = new Animal(5, Diet.Carnivoor);
            Animal animal2 = new Animal(1, Diet.Herbivoor);
            wagon.CheckIfAnimalFits(animal1);
            Assert.IsFalse(wagon.CheckIfAnimalFits(animal2));

        }
        [Test]
        public void BigCarnivoormediumHerbivoorInOneWagon()
        {
            Wagon wagon = new Wagon();

            Animal animal1 = new Animal(5, Diet.Carnivoor);
            Animal animal2 = new Animal(3, Diet.Herbivoor);
            wagon.CheckIfAnimalFits(animal1);
            Assert.IsFalse(wagon.CheckIfAnimalFits(animal2));
            

        }
        [Test]
        public void BigCarnivoorbigHerbivoorInOneWagon()
        {
            Wagon wagon = new Wagon();

            Animal animal1 = new Animal(5, Diet.Carnivoor);
            Animal animal2 = new Animal(5, Diet.Herbivoor);
            wagon.PlaceAnimal(animal1);
            Assert.IsFalse(wagon.CheckIfAnimalFits(animal2));

        }
        [Test]
        public void SmallCarnivoorSmallHerbivoorInOneWagon()
        {
            Wagon wagon = new Wagon();

            Animal animal1 = new Animal(1, Diet.Carnivoor);
            Animal animal2 = new Animal(1, Diet.Herbivoor);
            wagon.CheckIfAnimalFits(animal1);
            Assert.IsTrue(wagon.CheckIfAnimalFits(animal2));

        }
        [Test]
        public void SmallCarnivoormediumHerbivoorInOneWagon()
        {
            Animal animal1 = new Animal(1, Diet.Carnivoor);
            Animal animal2 = new Animal(3, Diet.Herbivoor);
            Wagon wagon = new Wagon(animal1);

            Assert.IsTrue(wagon.CheckIfAnimalFits(animal2));

        }

        [Test]
        public void WagonFit()
        {
            Wagon wagon = new Wagon();
            Animal animal1 = new Animal(1, Diet.Carnivoor);
            Animal animal2 = new Animal(3, Diet.Herbivoor);
            wagon.CheckIfAnimalFits(animal1);
            Assert.IsTrue(wagon.CheckIfAnimalFits(animal2)); 
        }
    }
}
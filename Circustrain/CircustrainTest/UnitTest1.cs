using circustrein;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CircustrainTest
{
    public class Tests
    {
       readonly Animal[][] _animalMatrix =
     {
            new Animal[] //animalMatrix[0]
            {
                new Animal(1, Diet.Carnivoor), //animal 0
                new Animal(3, Diet.Carnivoor), //animal 1
                new Animal(5, Diet.Carnivoor), //animal 2
                new Animal(1, Diet.Herbivoor), //animal 3
                new Animal(3, Diet.Herbivoor),//animal 4
                new Animal(5, Diet.Herbivoor) //animal 5
            },
            new Animal[] //animalMatrix[1]: Crossreference array
            {
                new Animal(1, Diet.Carnivoor),
                new Animal(3, Diet.Carnivoor),
                new Animal(5, Diet.Carnivoor),
                new Animal(1, Diet.Herbivoor),
                new Animal(3, Diet.Herbivoor),
                new Animal(5, Diet.Herbivoor)
            }
        };



      readonly  bool[][] _TrueBoolMatrix = // animals from one side to other side
            {
                new bool[]
                {
                    false, false, false, false, true, true
                },
                new bool[]
                {
                    false, false, false, false, true , true
                },
                new bool[]
                {
                    false, false, false, false, false, false
                },
                new bool[]
                {
                    false, false, false, true, true, true
                },
                new bool[]
                {
                    true, false, false, true, true, true
                },
                new bool[]
                {
                    true, true, false, true, true, true
                }
           };

        //[Test]
        //public void TestingMatrix()
        //{
        //    for (int x = 0; x < animalMatrix[0].Length; x++)
        //    {
        //        Wagon wagon = new Wagon(animalMatrix[0][x]);
                
        //        for (int y = 0; y < animalMatrix[1].Length; y++)
        //        {
        //            Assert.AreEqual(TrueBoolMatrix[x][y], wagon.CheckIfAnimalFits(animalMatrix[1][y]));
        //        }
        //    }
        //}

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
            Assert.AreEqual(3, train.Wagons.Count());
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
        public void SmallCarnivoorBigHerbivoorInOneWagon()
        {
          
            Wagon wagon = new Wagon();


            Animal animal1 = new Animal(1, Diet.Carnivoor);
            Animal animal2 = new Animal(5, Diet.Carnivoor);
            wagon.CheckIfAnimalFits(animal1);
            Assert.IsFalse(wagon.CheckIfAnimalFits(animal2));
            
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
            wagon.TryPlaceAnimal(animal1);
            Assert.IsFalse(wagon.CheckIfAnimalFits(animal2));

        }
        [Test]
        public void SmallCarnivoorSmallHerbivoorInOneWagon()
        {
            Wagon wagon = new Wagon();

            Animal animal1 = new Animal(1, Diet.Carnivoor);
            Animal animal2 = new Animal(1, Diet.Herbivoor);
            wagon.CheckIfAnimalFits(animal1);
            Assert.IsFalse(wagon.CheckIfAnimalFits(animal2));

        }
        [Test]
        public void SmallCarnivoormediumHerbivoorInOneWagon()
        {
            Wagon wagon = new Wagon();

            Animal animal1 = new Animal(1, Diet.Carnivoor);
            Animal animal2 = new Animal(3, Diet.Herbivoor);
            wagon.CheckIfAnimalFits(animal1);
            Assert.IsFalse(wagon.CheckIfAnimalFits(animal2));

        }
    }
}
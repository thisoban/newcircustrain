using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CircustrainV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestWagon
    {
        Animal[][] animalsarray =
        {
            new Animal[] {
                new Animal  (1, Diet.Carnivore),
                new Animal  (3, Diet.Carnivore),
                new Animal  (5, Diet.Carnivore),
                new Animal  (1, Diet.Herbivore),
                new Animal  (3, Diet.Herbivore),
                new Animal  (5, Diet.Herbivore)

            },
            new Animal[]
            {
                new Animal  (1, Diet.Carnivore),
                new Animal  (3, Diet.Carnivore),
                new Animal  (5, Diet.Carnivore),
                new Animal  (1, Diet.Herbivore),
                new Animal  (3, Diet.Herbivore),
                new Animal  (5, Diet.Herbivore)
            }
        };


        bool[][] TrueBoolMatrix = // animals from one side to other side
        {
            new bool[]
            {
                false, false, false, false, true, true
            },
            new bool[]
            {
                false, false, false, false, false , true
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

        [TestMethod]
        public void TestMatrix()
        {
            
            for (int x = 0; x < animalsarray[0].Length; x++)
            {
                Wagon wagon = new Wagon();
                wagon.PlaceAnimal(animalsarray[0][x]);
                for (int y = 0; y < animalsarray[1].Length; y++)
                {
;
                    Assert.AreEqual(TrueBoolMatrix[x][y], wagon.CanAnimalBePlaced(animalsarray[1][y]));
                }
            }
        }

        [TestMethod]
        public void TestPlacingAnimal()
        {
            Animal animal1 = new Animal(5, Diet.Herbivore);
            Wagon wagon = new Wagon();
            wagon.PlaceAnimal(animal1);
           Assert.AreEqual(1,wagon.Animals.Count() );
        }
        [TestMethod]
        public void TestCanAnimalBePlaced()
        {
            Animal animal1 = new Animal(5, Diet.Herbivore);
            Animal animal2 = new Animal(5, Diet.Herbivore);
            Animal animal3 = new Animal(5, Diet.Herbivore);
            Wagon wagon = new Wagon();
            wagon.PlaceAnimal(animal1);
            wagon.PlaceAnimal(animal2);
            Assert.IsFalse(wagon.CanAnimalBePlaced(animal3));
        }

        [TestMethod]
        public void TestMixAnimalPlacingBigHerbivoorBigCarnivoor()
        {
            Animal herbivoor = new Animal(5, Diet.Herbivore);
            Animal carnivoor = new Animal(5, Diet.Carnivore);
            Wagon wagon = new Wagon();
            wagon.PlaceAnimal(herbivoor);
            Assert.IsFalse(wagon.CanAnimalBePlaced(carnivoor));

        }

        [TestMethod]
        public void TestMixAnimalPlacing()
        {
            Animal herbivoor = new Animal(5, Diet.Herbivore);
            Animal carnivoor = new Animal(5, Diet.Carnivore);
            Wagon wagon = new Wagon();
            wagon.PlaceAnimal(herbivoor);
            Assert.IsFalse(wagon.CanAnimalBePlaced(carnivoor));

        }

       
        

    }
}

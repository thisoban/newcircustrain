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
        public void TestListAnimals1()
        {
            Train train = new Train();
            Wagon wagon = new Wagon();
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
        public void TestListAnimals2()
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
            Assert.Pass();
        }

        [Test]
        public void TestMatrix()
        {

        }
    }
}
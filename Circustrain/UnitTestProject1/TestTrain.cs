using System;
using System.Collections.Generic;
using System.Linq;
using CircustrainV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestTrain
    {
        [TestMethod]
        public void TestOrderAnimalsInWagon()
        {
            List<Animal> animals = new List<Animal>()
            {
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(3, Diet.Herbivore),
                 new Animal(3, Diet.Herbivore),
                 new Animal(3, Diet.Herbivore),
                 new Animal(5, Diet.Herbivore),
                 new Animal(5, Diet.Herbivore),
                 new Animal(5, Diet.Herbivore),
                 new Animal(5, Diet.Carnivore),
                 new Animal(3, Diet.Carnivore),
                 new Animal(1, Diet.Carnivore)
            };
           
            Train train = new Train();
            train.OrderAnimalsInWagons(animals);
            Assert.AreEqual(5, train.Wagons.Count());
        }
    }
}

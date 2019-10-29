using circustrein;
using NUnit.Framework;
using System.Collections.Generic;

namespace CircustrainTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Animal animal1 = new Animal(1, Diet.carnivoor);
            Animal animal2 = new Animal(3, Diet.herbivoor);
            Animal animal3 = new Animal(5, Diet.carnivoor);
            Animal animal4 = new Animal(3, Diet.herbivoor);
            List<Animal> animalsstation = new List<Animal>
            {
                animal1,
                animal2,
                animal3,
                animal4
            };


            Train train = new Train(animalsstation);
            train.SortingAnimals(animalsstation);

            Assert.Pass();
        }
    }
}
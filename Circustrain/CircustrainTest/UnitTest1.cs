using circustrein;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CircustrainTest
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Animal animal1 = new Animal(1, Diet.carnivoor);
            Animal animal2 = new Animal(5, Diet.herbivoor);
            Animal animal3 = new Animal(5, Diet.herbivoor);
           
            Animal animal4 = new Animal(3, Diet.herbivoor);
            Animal animal5 = new Animal(3, Diet.herbivoor);
            Animal animal6 = new Animal(3, Diet.herbivoor);
            List<Animal> animalsstation = new List<Animal>
            {
                animal6,
                animal4,
                animal3,
                animal2,
                animal1,
                animal5
            };


            Train train = new Train(animalsstation);
           
            Assert.Pass();
        }
    }
}
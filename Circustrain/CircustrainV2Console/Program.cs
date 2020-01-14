using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CircustrainV2;

namespace CircustrainV2Console
{
    class Program
    {
        static Animal[][] animalsarray =
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


        static bool[][] TrueBoolMatrix = // animals from one side to other side
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

        static void Main(string[] args)
        {
            //Console.WriteLine("hey ik ben henkie");
            //Train train = new Train();
            //List<Animal> animals = new List<Animal>();

            //animals.Add(new Animal(5, Diet.Carnivore));
            //animals.Add(new Animal(3, Diet.Carnivore));
            //animals.Add(new Animal(1, Diet.Carnivore));
            //animals.Add(new Animal(5, Diet.Herbivore));
            //animals.Add(new Animal(3, Diet.Herbivore));
            //animals.Add(new Animal(1, Diet.Herbivore));
            //animals.Add(new Animal(3, Diet.Herbivore));
            //animals.Add(new Animal(3, Diet.Herbivore));

            //train.OrderAnimalsInWagons(animals);
            //int wagonCount = 0;
            //foreach (Wagon wagon in train.Wagons)
            //{
            //    wagonCount++; 
            //    Console.WriteLine($"Wagon: {wagonCount.ToString()}");
            //    foreach (Animal animal in wagon.Animals)
            //    {
            //        Console.WriteLine(animal);
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("hey ik ben henkie2");


            Console.WriteLine("testmatrix");

            for (int x = 0; x < animalsarray[0].Length; x++)
            {
                Wagon wagon = new Wagon();
                wagon.PlaceAnimal(animalsarray[0][x]);
                for (int y = 0; y < animalsarray[1].Length; y++)
                {

                    Console.WriteLine(TrueBoolMatrix[x][y] + " , " + wagon.CanAnimalBePlaced(animalsarray[1][y]));
                }
            }


            Console.ReadKey();
        }
    }
}

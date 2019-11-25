using System;
using System.Collections.Generic;
using System.Text;
using circustrein;

namespace CircustrainTest
{
  public class TestMatrix
  {
        readonly List<Animal> _animalsperron = new List<Animal>();
        
        public void Test()
        {
            Animal[][] animalsarray =
            {
            new Animal[] {
              new Animal  (1, Diet.Carnivoor),
              new Animal  (3, Diet.Carnivoor),
              new Animal  (5, Diet.Carnivoor),
              new Animal  (1, Diet.Herbivoor),
              new Animal  (3, Diet.Herbivoor),
              new Animal  (5, Diet.Herbivoor)

             },
             new Animal[]
             {
              new Animal  (1, Diet.Carnivoor),
              new Animal  (3, Diet.Carnivoor),
              new Animal  (5, Diet.Carnivoor),
              new Animal  (1, Diet.Herbivoor),
              new Animal  (3, Diet.Herbivoor),
              new Animal  (5, Diet.Herbivoor)
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
           
        }
        
        public void TestMatrixTesting()
        {
          
        }
    }
}

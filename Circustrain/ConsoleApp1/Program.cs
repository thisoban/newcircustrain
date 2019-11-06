using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using circustrein;
namespace ConsoleApp1
{
   public class Program
    {
        
       public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();
            train.SortAnimals(animals);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Train
    {
        private readonly List<Wagon> _wagons;
        //private List<Animal> _sortedlist;
        public IEnumerable<Wagon> Wagons { get { return _wagons; } }
        public Train(List<Animal> perronanimals)
        {
            _wagons = new List<Wagon>();
            CanAnimalBePlaced(perronanimals);
        }

        public void IThink()
        {
           // hier moet nog een naam voor komen en can animalbeplaced in uitvoeren
        }
        
        public bool CanAnimalBePlaced(List<Animal>animalsperron)
        {
            List<Animal> animals = animalsperron.OrderBy(a => a.Diet).ThenByDescending(a => a.Weight).ToList();

            //sorteren
            foreach (Animal animal in animals)
            {
                if (IsthereSpaceInAnyWagon(animal) == false)
                {
                    //moe teen ding doen moet opsliten in tweeen
                    //AddWagonToList();
                    return false;
                }
                return true;
            }
            return false ;
        }
       
        private bool IsthereSpaceInAnyWagon(Animal animal)
        {
            if (_wagons.Count > 0)
            {
                foreach (Wagon wagon in _wagons)
                {
                    wagon.CheckingAnimalFit(animal);
                    return true;
                }
            }
            return false;
        }
        private void AddWagonToList(Wagon wagon)
        {
            _wagons.Add(wagon);
        }
    }
}

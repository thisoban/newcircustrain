using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Animal
    {
        public int Weight { get; set; }
        public Diet Diet { get; set; }

        public Animal(int weight, Diet diet)
        {
            Weight = weight;
            Diet = Diet;
        }

    }
}

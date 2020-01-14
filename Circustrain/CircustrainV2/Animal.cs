using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustrainV2
{
   public class Animal
    {
        public int Weight { get; }
        public Diet Diet { get;  }

        public Animal(int weight, Diet diet)
        {
            Weight = weight;
            Diet = diet;
        }

        public override string ToString()
        {
            return Weight.ToString() + " " + Diet.ToString();
        }
    }
}

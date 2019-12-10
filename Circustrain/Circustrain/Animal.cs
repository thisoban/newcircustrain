namespace circustrein
{
    public class Animal
    {
        public int Weight { get; set; }
        public Diet Diet { get; set; }

        public Animal(int weight, Diet diet)
        {
            Weight = weight;
            Diet = diet;
        }

        public bool IsHerbivoreBiggerThenCarnivore( Animal animal)
        {
            if (animal.Diet == Diet.Herbivoor)
            {
                if (Weight < animal.Weight) return true;
                return false;
            }
            return false;
        }
    }
}

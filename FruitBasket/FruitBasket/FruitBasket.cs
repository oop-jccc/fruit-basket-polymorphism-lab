using System.Collections.Generic;
using System.Linq;

namespace FruitBasket
{
    internal class FruitBasket
    {
        private readonly List<Fruit> _basket = new();

        public Fruit Add(Fruit fruit)
        {
            _basket.Add(fruit);
            return fruit;
        }

        //TODO: Create Remove, Empty and Cost methods
    }
}

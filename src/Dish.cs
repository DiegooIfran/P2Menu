using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public bool IsVegetarian { get; set; }

        public Dish(string name, float price, bool isVegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isVegetarian;
        }
    }
}
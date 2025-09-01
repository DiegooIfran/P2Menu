using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        private void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
        private void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        private Dish GetDish(string nameDish)
        {
            foreach (Dish dish in this.dishes)
            {
                if (nameDish == dish.name)
                {
                    return dish;
                }
            }
            return null;
        }
    }
}
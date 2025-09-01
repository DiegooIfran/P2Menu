using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private List<Dish> order = new List<Dish>();
        public int Number;
        public bool IsOccupied = false;
        public Table(int number)
        {
            this.Number = number;
        }   
        // Permite saber si la mesa tiene ordenes o no
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
        // Agrego platos a la lista de pedidos
        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }
        
        
        public void Ocupy()
        {
            IsOccupied = true;
        }

        public void Free()
        {
            IsOccupied = false;
            order.Clear();
        }
    }
}
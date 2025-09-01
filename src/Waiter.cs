using System.Collections.Generic;
using System.Runtime.InteropServices.ObjectiveC;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private List<Table> assignedTables = new List<Table>();
        public string Name;
        
        public Waiter(string name)
        {
            this.Name = name;
        }
        
        public void AssignTable(Table mesa)
        {
            assignedTables.Add(mesa);
        }
        
        public void TakeOrder(Table mesa, Dish plato)
        {
            mesa.AddToOrder(plato);
        }
    }
}
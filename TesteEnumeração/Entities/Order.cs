using System;
using System.Collections.Generic;
using System.Text;
using TesteEnumeração.Entities.Enums;

namespace TesteEnumeração.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public void AddItems(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItems(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem obj in Items)
            {
                sum += obj.SubTotal();
            }
            return sum;
        }
    }
}

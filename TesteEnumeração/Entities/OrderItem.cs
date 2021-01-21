using System;
using System.Collections.Generic;
using System.Text;

namespace TesteEnumeração.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public double SubTotal()
        {
            Price = Quantity * Product.Price;
            return Price;
        }
    }
}

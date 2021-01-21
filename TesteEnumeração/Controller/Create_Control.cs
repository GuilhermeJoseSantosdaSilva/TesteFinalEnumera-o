using System;
using System.Collections.Generic;
using System.Text;
using TesteEnumeração.Entities;
using TesteEnumeração.Entities.Enums;

namespace TesteEnumeração.Controller
{
    class Create_Control
    {
        public static Product CreateProduct(string name, double price)
        {
            Product a = new Product
            {
                Name = name,
                Price = price
            };

            return a;
        }

        public static OrderItem CreateOrderItem (int quantity, Product product)
        {
            OrderItem a = new OrderItem
            {
                Quantity = quantity,
                Product = product,
            };
            a.Price = a.SubTotal();
            return a;
        }

        public static Client CreateClient(string name, string email, DateTime birthday)
        {
            Client a = new Client()
            {
                Name = name,
                Email = email,
                BirthDate = birthday
            };
            return a;
        }

        public static Order CreateOrder(DateTime moment, List<OrderItem> items, OrderStatus status, Client client)
        {
            Order a = new Order()
            {
                Moment = moment,
                Items = items,
                Status = status,
                Client = client
            };
            return a;
        }
    }
}

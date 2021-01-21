using System;
using System.Collections.Generic;
using System.Text;
using TesteEnumeração.Entities;
using TesteEnumeração.Controller.Lists;

namespace TesteEnumeração.Controller
{
    class List_Control
    {
        public static List<Product> ProductList { get; set; } = new List<Product>();
        public static List<Client> ClientList { get; set; } = new List<Client>(); 
        public static void UniqueListOrder(int id, List<OrderItem> orderItems)
        {
            OrderItensList.Id.Add(id);
            OrderItensList.OrderItems.Add(orderItems);
        }
    }
}

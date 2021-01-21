using System;
using System.Collections.Generic;
using System.Text;
using TesteEnumeração.Entities;

namespace TesteEnumeração.Controller
{
    class List_Control
    {
        public static List<Product> ProductList { get; set; } = new List<Product>();
        public static List<Client> ClientList { get; set; } = new List<Client>();
        public static List<Order> OrderList { get; set; } = new List<Order>();
    }
}

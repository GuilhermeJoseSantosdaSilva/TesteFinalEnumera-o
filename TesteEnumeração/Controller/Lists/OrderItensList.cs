using System;
using System.Collections.Generic;
using System.Text;
using TesteEnumeração.Entities;

namespace TesteEnumeração.Controller.Lists
{
    class OrderItensList
    {
        public static List<int> Id { get; set; }
        public static List<List<OrderItem>> OrderItems { get; set; }
    }
}

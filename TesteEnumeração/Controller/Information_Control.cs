using System;
using System.Collections.Generic;
using System.Text;
using TesteEnumeração.Entities;
using TesteEnumeração.Entities.Enums;

namespace TesteEnumeração.Controller
{
    class Information_Control
    {
        public static void InsertClient()
        {
            Console.Write("\nEnter the Client's name: ");
            string name = Console.ReadLine();
            Console.Write("\nEnter the Client's email: ");
            string email = Console.ReadLine();
            Console.Write("\nEnter the Client's BirthDate (DD/MM/YYYY): ");
            string[] dat = Console.ReadLine().Split('/');
            int day, month, year;
            day = Convert.ToInt32(dat[0]);
            month = Convert.ToInt32(dat[1]);
            year = Convert.ToInt32(dat[2]);
            DateTime dateTime = new DateTime(year, month, day);
            Client a = Create_Control.CreateClient(name, email, dateTime);
            List_Control.ClientList.Add(a);
        }

        public static void InsertProduct()
        {
            Console.Write("\nEnter Product's name: ");
            string name = Console.ReadLine();
            Console.Write("\nEnter Product's price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Product a = Create_Control.CreateProduct(name, price);
            List_Control.ProductList.Add(a);
        }

        public static void InsertOrderItem(Order Order)
        {
            if (List_Control.ProductList.Count > 0)
            {
                Console.WriteLine("\nSet the OrderItem quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter the Product's Id: ");
                for (int i = 0; i < List_Control.ProductList.Count; i++)
                {
                    Console.WriteLine($"\n#{i}: {List_Control.ProductList[i].Name}");
                }
                int id_product = Convert.ToInt32(Console.ReadLine());
                Product product = List_Control.ProductList[id_product];
                OrderItem a = Create_Control.CreateOrderItem(quantity, product);
                Order.AddItems(a);
            }
            else
            {
                Console.WriteLine("To make an Order in first place you need to Insert a Product :(");
            }
        }

        public static Order InsertOrder()
        {
            DateTime moment = DateTime.Now;
            Console.WriteLine("Set Order's Client: ");
            for(int i = 0; i < List_Control.ClientList.Count; i++)
            {
                Console.WriteLine($"\n#{i}: {List_Control.ClientList[i].Name}");
            }
            int id_client = Convert.ToInt32(Console.ReadLine());
            Client client = List_Control.ClientList[id_client];
            Console.WriteLine("Enter Order's Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Order's situation(SENDING/PENDING_PAYMENT/DELIVERED/PROCESSING): ");
            OrderStatus b = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order a = Create_Control.CreateOrder(moment, b, client, id);
            return a;
        }
    }
}

using System;
using TesteEnumeração.Controller;
using TesteEnumeração.Entities;
using TesteEnumeração.Entities.Enums;

namespace TesteEnumeração
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x != 5)
            {
                Console.WriteLine("\nEnter wich operation do you want realize: \n1-Insert Product \n2-Insert Client \n3-Insert Order \n4-View Order \n5-Get out of here");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Information_Control.InsertProduct();
                        break;
                    case 2:
                        Information_Control.InsertClient();
                        break;
                    case 3:
                       Order order = Information_Control.InsertOrder();
                        Information_Control.InsertOrderItem(order);                       
                        char z = 's';
                        while(z != 'n')
                        {
                            Console.WriteLine("\bDo you want to add another order? (s/n)");
                            z = Convert.ToChar(Console.ReadLine());
                            if(z == 's')
                            {
                                Information_Control.InsertOrderItem(order);
                            }
                        }
                        List_Control.OrderList.Add(order);
                        break;
                    case 4:
                        foreach(Order obj in List_Control.OrderList)
                        {
                            Console.WriteLine($"\n#{obj.Id}, Client: {obj.Client.Name}, {obj.Client.Email}, {obj.Client.BirthDate} \nOrder Moment: {obj.Moment} \nOrder Status: {obj.Status}");
                            Console.WriteLine($"Order Itens:");
                            foreach (OrderItem item in obj.Items)
                            {
                                Console.WriteLine($"{item.Product.Name}, quantity {item.Quantity}, price: {item.Product.Price:F2}, subtotal: {item.SubTotal():F2}");
                            }
                            Console.WriteLine($"Total: {obj.Total():F2}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Good Bye :)");
                        break;
                    default:
                        x = 5;
                        Console.WriteLine("Enter an unauthorized number");
                        break;
                }
            }
        }
    }
}

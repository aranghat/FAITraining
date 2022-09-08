using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer { CustomerId = 1001, Email = "sreehariis@gmail.com", Name = "Sree" };
            Customer c2 = new Customer { CustomerId = 1002, Email = "kate@gmail.com", Name = "Kate" };
            Customer c3 = new Customer { CustomerId = 1003, Email = "mark@gmail.com", Name = "Mark" };

            Product p1 = new Product { ProductId = 1, Name = "Coffee", UnitPrice = 100.5F };
            Product p2 = new Product { ProductId = 2, Name = "Tea", UnitPrice = 120 };
            Product p3 = new Product { ProductId = 3, Name = "Shampoo", UnitPrice = 200 };
            Product p4 = new Product { ProductId = 4, Name = "Brushes", UnitPrice = 100 };

            Order o1 = new Order { CustomerId = c1.CustomerId, ProductId = p1.ProductId, OrderDate = DateTime.Now, OrderId = 1, OrderStatus = OrderStatus.DELIVERED };
            Order o2 = new Order { CustomerId = c2.CustomerId, ProductId = p1.ProductId, OrderDate = DateTime.Now, OrderId = 2, OrderStatus = OrderStatus.ONPROGRESS };
            Order o3 = new Order { CustomerId = c3.CustomerId, ProductId = p2.ProductId, OrderDate = DateTime.Now, OrderId = 3, OrderStatus = OrderStatus.OURFORDELIEVERY };
            Order o4 = new Order { CustomerId = c1.CustomerId, ProductId = p3.ProductId, OrderDate = DateTime.Now, OrderId = 4, OrderStatus = OrderStatus.DELIVERED };
            Order o5 = new Order { CustomerId = c1.CustomerId, ProductId = p4.ProductId, OrderDate = DateTime.Now, OrderId = 5, OrderStatus = OrderStatus.DELIVERED };


            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);

            List<Order> orders = new List<Order>();
            orders.Add(o1);
            orders.Add(o2);
            orders.Add(o3);
            orders.Add(o4);
            orders.Add(o5);

            //var data = from o in orders
            //           join p in products on o.ProductId equals p.ProductId
            //           //select new { Order = o, Product = p };
            //           select new { ProductName = p.Name, OrderID = o.OrderId, Status = o.OrderStatus };

            var data = orders.Join(customers
                                            , customer => customer.CustomerId
                                            , order => order.CustomerId
                                            , (customer, order) => new { order, customer });

            //foreach (var d in data)
            //    Console.WriteLine($"{d.ProductName}\t{d.OrderID}\t{d.Status}");

            //foreach (var d in data)
            //    Console.WriteLine(d.order.CustomerId + " " + d.customer.OrderStatus);

            //if (orders.Any(d => d.OrderStatus != OrderStatus.DELIVERED))
            //    Console.WriteLine("There are still items to be delivered");
            //else
            //    Console.WriteLine("All items are delivered");

            //if (orders.Where(d => d.CustomerId == 1).All(d => d.OrderStatus == OrderStatus.DELIVERED))
            //    Console.WriteLine("All items are delivered");
            //else
            //    Console.WriteLine("There are still items ot be deliverd");

            for(int i=4; i<100;i++)
            {
                Customer c = new Customer();
                c.CustomerId = 1000 + i;
                c.Name = "Customer " + c.CustomerId;
                c.Email = c.CustomerId + "@test.com";

                customers.Add(c);
            }

            Console.WriteLine("Total Customers = " + customers.Count);

            int pageSize = 20;
            int pageNumber = 2;

            foreach(var c in customers.Skip(pageSize * (pageNumber-1)).Take(pageSize))
            {
                Console.WriteLine(c);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace week08
{
    public class OrderService
    {
        public List<Order> orderList { get; set; }

        public OrderService()
        {
            orderList = new List<Order>();
        }

        public void AddOrder(Order o)
        {
            using(var context =new OrderContext())
            {
                var result = context.Orders.SingleOrDefault(b => b.OrderId == o.OrderId);
                if (result != null)
                {
                    throw new Exception("This order has existed");
                }
                context.Orders.Add(o);
                context.SaveChanges();
            }
        }

        public void DeleteOrder(Order o)
        {
            using (var context = new OrderContext())
            {
                var result = context.Orders.SingleOrDefault(b => b.OrderId == o.OrderId);
                if (result == null)
                {
                    throw new Exception("This order is not exist!");
                }
                orderList.Remove(o);
                context.Orders.Remove(o);
                context.SaveChanges();
            }
        }

        public void ChangeOrder(Order preO, Order lastO)
        {
            using (var context = new OrderContext())
            {
                var result = context.Orders.SingleOrDefault(b => b.OrderId == preO.OrderId);
                if (result == null)
                {
                    throw new Exception("This order is not exist!");
                }
                result = context.Orders.SingleOrDefault(b => b.OrderId == lastO.OrderId);
                if (result != null)
                {
                    throw new Exception("The order you want to add has existed1");
                }
                orderList.Remove(preO);
                orderList.Add(lastO);
                context.Orders.Remove(preO);
                context.Orders.Remove(lastO);
                context.SaveChanges();
            }
        }

        public Order SearchOrderById(int id)
        {
            Order o;
            using (var context = new OrderContext())
            {
                var result = context.Orders.SingleOrDefault(b => b.OrderId == id);
                if (result == null)
                {
                    throw new Exception("This order is not exist!");
                }
                o = result;
            }
            orderList.Add(o);
            return o;
        }

        public List<Order> SearchOrderByGoodName(string name)
        {
            List<Order> list = new List<Order>();
            using (var context = new OrderContext())
            {
                var ods = context.Details.Where(b => b.goods.Name == name);
                int[] arr = new int[ods.Count()];
                int count = 0;
                foreach(OrderDetails od in ods)
                {
                    arr[count] = od.OrderId;
                    count++;
                }
                var result = context.Orders.Where(b => arr.Contains(b.OrderId)).OrderBy(b=>b.OrderId);
                list = result as List<Order>;

            }
            orderList.AddRange(list);
            return list;
        }

        public List<Order> FindAll() 
        {
            using (var context = new OrderContext())
            {
                var result = context.Orders.Where(b => true);
                return result as List<Order>;
            }
        }

        public List<Order> SearchOrderByCustomerName(string customer)
        {
            using (var context = new OrderContext())
            {
                List<Order> list = new List<Order>();
                var query = from order in context.Orders where order.Customer.Name.Equals(customer) orderby order.OrderId select order;
                if (query.FirstOrDefault() == null) return list;
                else
                {
                    foreach (Order order in query)
                    {
                        list.Add(order);
                    }
                    return list;
                }
            }
        }

        public List<Order> SearchOrderByTotalPrice(double from_, double to)
        {
            using (var context = new OrderContext())
            {
                List<Order> list = new List<Order>();
                var _query = from order in context.Orders where order.getAndSetTotalPrice() >= from_ orderby order.OrderId select order;
                var query = from order in _query where order.getAndSetTotalPrice() <= to orderby order.OrderId select order;
                if (query.FirstOrDefault() == null) return list;
                else
                {
                    foreach (Order order in query)
                    {
                        list.Add(order);
                    }
                    return list;
                }
            }
        }

        public void Sort()
        {
            orderList.Sort();
        }

        public void Sort(IComparer<Order> comparer)
        {
            orderList.Sort(comparer);
        }

        public void ShowAllOrder()
        {
            foreach (Order o in orderList)
            {
                Console.WriteLine(o);
            }
        }

        public void Export()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("order.xml", FileMode.Create))
            {
                serializer.Serialize(fs, orderList);
            }
        }

        public void Import()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("order.xml", FileMode.Open))
            {
                orderList = (List<Order>)serializer.Deserialize(fs);
            }
        }
    }
}

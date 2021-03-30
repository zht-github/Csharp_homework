using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order_Managing_System
{
    class Program
    {
        
        class Order
        {
            public OrderDetails orderDetails { get; }
            public double TotalPrice
            {
                get
                {
                    double sum = 0;
                    items.ForEach(x => sum += x.TotalPrice);
                    return sum;
                }
            }
            public List<Item> items = new List<Item>();
            public Order(int id, String clientName, DateTime dueDate, String address)//默认初始化
            {
                this.orderDetails = new OrderDetails(id, clientName, dueDate, address);
            }

            public Order(int id, String clientName, DateTime dueDate, String address,List<Item> items) ://批量初始化添加
                this(id,clientName,dueDate,address)
            {
                this.items.AddRange(items);
            }
            public override string ToString()
            {
                int count = 0;
                var sb = new StringBuilder();
                sb.Append("==================================\n");
                sb.Append(this.orderDetails.ToString());
                sb.Append($"\nTotal Price:{TotalPrice}");
                items.ForEach(x =>
                {
                    sb.Append("\n--------------------------------\n");
                    count++;
                    sb.Append($" Item {count}:");
                    sb.Append(x.ToString());
                });
                sb.Append("\n==================================");
                return sb.ToString();
            }
            public override bool Equals(object obj)
            {
                return this.orderDetails.Equals((obj as Order).orderDetails);
            }
        }
        class OrderDetails
        {
            public int ID { get; }
            public String Client { get; }
            public DateTime Deadline { get; }
            public String Address { get; }

            public OrderDetails(int id, String clientName,DateTime dueDate,String address)
            {
                this.ID = id;
                this.Client = clientName;
                this.Deadline = dueDate;
                this.Address = address;
            }
            public override bool Equals(object obj)
            {
                return this.ID == (obj as OrderDetails).ID;
            }
            public override string ToString()
            {
                return $"Order id:{ID}\nclient:{Client}\ndeadline:{Deadline.ToString()}\naddress:{Address}";

            }

        }
        class Item
        {
            public int ItemAmount;
            private ItemDescription ItemDescription;
            public ItemDescription itemDescription { get { return ItemDescription; } }
            public double TotalPrice { get { return ItemDescription.Price * ItemAmount; } }
            public Item(String name, int id, double price, String description,int amount)
            {
                this.ItemDescription = new ItemDescription(name,id,price,description);
                this.ItemAmount = amount;

            }
            public override string ToString()
            {
                return $"{this.ItemDescription.ToString()}\n  amount:{ItemAmount}\nitem total price:{TotalPrice}";
            }
            public override bool Equals(object obj)
            {
                return this.ItemDescription.Equals((obj as Item).ItemDescription);
            }
        }
        class ItemDescription
        {
            public String Name;
            public int ID;
            public double Price;
            public String Descrption;
            public ItemDescription(String name,int id,double price,String description)
            {
                this.Name = name;
                this.ID = id;
                this.Price = price;
                this.Descrption = description;
            }

            public override string ToString()
            {
                return $"  item name:{Name}\n  item id:{ID}\n  item price:{Price}\n  item description:{Descrption}";
            }
            public override bool Equals(object obj)
            {
                return this.ID == (obj as ItemDescription).ID;
            }
        }
        class OrderService
        {
            private List<Order> Orders = new List<Order>();
            public void SaveOrder(Order order)
            {
                bool judge = true;
                this.Orders.ForEach(x => { if (order.Equals(x)) judge = false; });
                if (judge == false) throw new Exception("新输入的order ID重复");
                this.Orders.Add(order);
                Orders.Sort((Order a, Order b) => { return a.orderDetails.ID - b.orderDetails.ID; });//插入后自动排序
            }
            public Order DeleteOeder(int orderId)
            {
                var target = GetOrder(orderId);
                this.Orders.Remove(target);
                return target;
            }
            public Order GetOrder(int orderId)
            {
                var query1 = from order in Orders where order.orderDetails.ID == orderId select order;
                if (query1.Count() == 0) throw new Exception("Order id Input error!!!");
                return query1.ToArray()[0];
            }
            public Item GetItemFromOrder(int orderId, int itemId)
            {
                var orderToAdjust = GetOrder(orderId);
                var query2 = from item in orderToAdjust.items
                             where item.itemDescription.ID == itemId
                             select item;
                if (query2.Count() == 0) throw new Exception("Item id Input error!!!");
                return query2.First();
            }
            public void AddOrderItem(int orderId,Item item)
            {
                GetOrder(orderId).items.Add(item);
            }
            public void DeleteOrderItem(int orderId, int itemId)
            {
                var orderToAdjust = GetOrder(orderId);
                var query2 = from item in orderToAdjust.items 
                                   where item.itemDescription.ID == itemId 
                                   select item;
                if (query2.Count() == 0) throw new Exception("Item id Input error!!!");
                orderToAdjust.items.Remove(query2.ToArray()[0]);
                if (orderToAdjust.items.Count == 0) throw new Exception("ERROR!删除后此订单无物品");
            }
            public void ModifyItemAmount(int orderId, int itemId,int newAmount)
            {
                if (newAmount <= 0) throw new Exception("item amount input error!!!");
                GetItemFromOrder(orderId, itemId).ItemAmount = newAmount;
            }
            public void PrintAllOrders()
            {
                Console.WriteLine("以下展示所有订单信息：");
                Orders.ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });
            }
        }
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            os.SaveOrder(new Order(1, "Jack", new DateTime(2021, 3, 30), "武汉大学信息学部"));
            os.AddOrderItem(1, new Item("皇帝柑", 1, 10, "很好吃，很甜", 2));
            List<Item> itemList = new List<Item> {new Item("练习册",2,1.5,"作业专用本",30),new Item("圆珠笔",3,5,"每人两支好用的圆珠笔",60) };
            Order secondOrder = new Order(2, "Mary", new DateTime(2021, 4, 1), "信息学部一教学楼", itemList);
            os.SaveOrder(secondOrder);
            try
            {
                os.ModifyItemAmount(2, 3, -1);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine("\n");
            try
            {
                os.SaveOrder(new Order(1, "Mike", new DateTime(2021, 3, 20), "武汉大学文理学部"));
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine("\n");
            os.PrintAllOrders();
        }
    }
}

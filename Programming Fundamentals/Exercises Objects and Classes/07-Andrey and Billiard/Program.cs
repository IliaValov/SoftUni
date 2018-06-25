using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, decimal> products = new Dictionary<string, decimal>();
        Dictionary<string, long> customers =
            new Dictionary<string, long>();
        ////Dictionary<string, long> bill = new Dictionary<string, long>();
        



        long foodCount = long.Parse(Console.ReadLine());
        decimal totalBill = 0;
        for (long i = 0; i < foodCount; i++)
        {
            string[] foodAndPrice = Console.ReadLine().Split('-');
            if (!products.ContainsKey(foodAndPrice[0]))
            {
                products.Add(foodAndPrice[0], decimal.Parse(foodAndPrice[1]));
            }
            else if (products.ContainsKey(foodAndPrice[0]))
            {
                products[foodAndPrice[0]] = decimal.Parse(foodAndPrice[1]);
            }
        }


        while (true)
        {
            string input = Console.ReadLine();
            string[] customer = input.Split('-', ',');           

            if (customer[0] == "end of clients")
            {
                break;
            }

            if (!customers.ContainsKey(customer[0]))
            {
                if (products.ContainsKey(customer[1]))
                {
                    customers.Add(customer[1], int.Parse(customer[2]));
                    Customer nameAndShop = new Customer(customer[0], customers);
                }


            }
            else if (customers.ContainsKey(customer[0]))
            {
                if (!customers[customer[0]].ContainsKey(customer[1]))
                {
                    customers[customer[0]].Add(customer[1], long.Parse(customer[2]));
                }
                else if (customers[customer[0]].ContainsKey(customer[1]))
                {
                    customers[customer[0]][customer[1]] = long.Parse(customer[2]);
                }


            }
        }

        foreach (var name in customers.OrderBy(n => n.Key))
        {
            Console.WriteLine(name.Key);
            foreach (var product in name.Value)
            {

                foreach (var bill in products)
                {

                    if (!products.ContainsKey(product.Key))
                    {
                        break;
                    }

                    if (product.Key == bill.Key)
                    {
                        Console.WriteLine($"-- {product.Key} - {product.Value}");

                        Console.WriteLine($"Bill: {bill.Value * product.Value:F2}");
                        totalBill += bill.Value * product.Value;
                    }
                }
            }
        }
        Console.WriteLine($"Total bill: {totalBill:F2}");

    }

    class Student
    {
        public Student(List<string> name)
        {
            Name = name;
        }

        public List<string> Name { get; set; }
    }
    class Customer
    {
        public Customer(string name, Dictionary<string, long> shopList)
        {
            Name = name;
            ShopList = shopList;
        }

        public string Name { get; set; }
        public Dictionary<string, long> ShopList { get; set; }
    }
}




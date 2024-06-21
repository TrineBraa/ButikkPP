using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButikkPP
{

    internal class Shops
    {
        public string _name;
        public string _type;
        public int _pricelevel;
        //List<int> price = new List<int>()
        //{
        //    1,2,3
        //};

        public Shops(string Name, string Type, int PriceLevel)
        {
            _name = Name;
            _type = Type;
            _pricelevel = PriceLevel;
        }

        public Shops()
        {

        }

        public void ShopMenu(List<Shops> allShops)
        {
            PrintAllShops(allShops);


        }

        public void PrintAllShops(List<Shops> allShops)
        {
            Console.Clear();
            foreach (var shops in allShops)
            {
                Console.WriteLine($"\nShop name: {shops._name}");
                Console.WriteLine($"Shop Type: {shops._type}");
                Console.WriteLine($"Price level: {shops._pricelevel}");
            }

            Console.ReadKey();
        }

        public void SortingMethod(List<Shops> allShops)
        {
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("choose how to sort the shops");
                Console.WriteLine("\n Cheap");
                Console.WriteLine("\n Midrange");
                Console.WriteLine("\n Expensive");
                var Sorting = Console.ReadLine().ToLower();

                if (Sorting == "cheap")
                {
                    Cheap(allShops);
                    break;
                }
                else if (Sorting == "expensive")
                {
                    Expensive(allShops);
                    break;
                }
                else if(Sorting == "Midrange")
                {
                    Midrange(allShops);
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose one of the options above!");
                    Thread.Sleep(2000);
                }
            }

        }


        public void Cheap(List<Shops> allShops)
        {
            Console.Clear();

            int range = 1;
            var cheapShops = allShops.FindAll(Shops => Shops._pricelevel.Equals(range));

            if (cheapShops != null && cheapShops.Count > 0)
            {
                foreach (var Shops in cheapShops)
                {
                    Console.WriteLine($"{Shops._name}");
                }

               
            }
            else
            {
                Console.WriteLine("No shops found.");

            }

            Console.ReadKey();

        }

        public void Midrange(List<Shops> allShops)
        {
            Console.Clear();

            int range = 2;
            var cheapShops = allShops.FindAll(Shops => Shops._pricelevel.Equals(range));

            if (cheapShops != null && cheapShops.Count > 0)
            {
                foreach (var Shops in cheapShops)
                {
                    Console.WriteLine($"{Shops._name}");
                }


            }
            else
            {
                Console.WriteLine("No shops found.");

            }

            Console.ReadKey();
        }


        public void Expensive(List<Shops> allShops)
        {
            Console.Clear();

            int range = 3;
            var cheapShops = allShops.FindAll(Shops => Shops._pricelevel.Equals(range));

            if (cheapShops != null && cheapShops.Count > 0)
            {
                foreach (var Shops in cheapShops)
                {
                    Console.WriteLine($"{Shops._name}");
                }


            }
            else
            {
                Console.WriteLine("No shops found.");

            }

            Console.ReadKey();
        }

        public void addNew(List<Shops> allShops)
        {


            while (true) { 
                Console.Clear();

            Console.WriteLine("What is the name of the shop?");
                var name = Console.ReadLine();
                Console.WriteLine("What type?");
                var type = Console.ReadLine();
                Console.WriteLine("Price level 1-3?");

                int price;
                var priceLevel = int.TryParse(Console.ReadLine(), out price);

                if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty");
                Thread.Sleep(2000);
            } else if (string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("Type cannot be empty");
                Thread.Sleep(2000);
            } else if (!priceLevel || price>3 || price<1)
            {
                Console.WriteLine("Enter valid price level");
                Thread.Sleep(2000);
            }
            else
            {
                Console.Clear();
                allShops.Add(new Shops(name, type, price));
                Console.WriteLine($"\"{name}\" was added successfully");
                Thread.Sleep(2000);
                    break;
            }
            }

        }
    }
}
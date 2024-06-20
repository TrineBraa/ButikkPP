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

         public void ShopMenu(List<Shops>allShops)
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

        public void SortingMethod(List<Shops>allShops)
        {
            while (true)
            {
                Console.WriteLine("choose how to sort the shops");
                Console.WriteLine("\n Cheap");
                Console.WriteLine("\n Expensive");
                var Sorting = Console.ReadLine().ToLower();

                if (Sorting == "cheap")
                {
                    Cheap(allShops);
                }
                else if (Sorting == "expensive")
                {
                    Expensive(allShops);
                }
                else
                {
                    Console.WriteLine("Please choose one of the options above!");
                }
            }

        }


        public void Cheap(List<Shops>allShops)
        {

        }



        public void Expensive(List<Shops> allShops)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_inventory_management.src
{
    public class Store
    {

        private List<Item> _items = [];
        private int _maximumCapacity;

        private string _name;



        public Store(string name, int maximumCapacity)
        {
            _name = name;
            _maximumCapacity = maximumCapacity;
        }

        public string GetName()
        {
            return _name;
        }

        public void AddItem(Item inputItem)
        {

            Item? item = _items.Find(item => item.GetName() == inputItem.GetName());

            if (item is null && (GetCurrentVolume() + inputItem.GetQuantity()) < _maximumCapacity && (inputItem.GetQuantity() > 0))
            {
                _items.Add(inputItem);
                Console.WriteLine("ADDED SUCCEFULY");
            }
            else
            {
                Console.WriteLine($"The {inputItem.GetName()} is already exist or the capasity it dose not allwoed");
            }
        }

        public List<Item> GetItems()
        {
            return _items;
        }


        public void DeleteItem(string inputItemName)
        {

            Item? item = _items.Find(item => item.GetName() == inputItemName);
            if (item is null)
            {
                Console.WriteLine($"The {inputItemName} it dose not exist");
            }
            else
            {
                _items.Remove(item);

                Console.WriteLine($"The {inputItemName} is DELETED SUCCEFULY!");
            }

        }

        public Item FindItemByName(string itemName)
        {
            Item? foundItem = _items.Find(item => item.GetName() == itemName);
            if (foundItem is not null)
            {
                return foundItem;
            }
            throw new ArgumentException($"Cannot find {itemName}");

        }

        public void SortByNameAsc()
        {
            var orderByResult = from item in _items
                                orderby item.GetName()
                                select item.GetName();

            foreach (var item in orderByResult)
            {
                Console.WriteLine(item);
            }
        }

        public int GetCurrentVolume()
        {
            int totalAmout = 0;
            _items.ForEach(item =>
            {
                totalAmout += item.GetQuantity();
            });

            return totalAmout;
        }

        public List<Item> SortByDate(SortOrder order)
        {
            var result = new List<Item>();
            if (order == SortOrder.ASC)
            {
                result = _items.OrderBy(item => item.GetDate()).ToList();

            }

            if (order == SortOrder.DECS)
            {
                result = _items.OrderByDescending(item => item.GetDate()).ToList();
            }
            return result;
        }

        public void GroupByDate()
        {
            var CurrentgroupByDate = _items.GroupBy(item =>
            {
                if ((DateTime.Now - item.GetDate()).TotalDays < 90)
                {
                    return "new";
                }
                return "old";
            });
            Console.WriteLine("========================================");


            foreach (var group in CurrentgroupByDate)
            {
                Console.WriteLine($"{group.Key} Items:");
                foreach (var item in group)
                {
                    Console.WriteLine($" - {item.GetName()}, Created: {item.GetDate().ToShortDateString()}");
                }
            }
        }
    }
}
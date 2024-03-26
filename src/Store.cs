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


        public Store(int maximumCapacity)
        {
            _maximumCapacity = maximumCapacity;
        }

        public void AddItem(Item inputItem)
        {

            Item? item = _items.Find(item => item.GetName() == inputItem.GetName());

            if (item is null && (GetCurrentVolume() + inputItem.GetQuantity()) < _maximumCapacity)
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


        public void DeletItem(Item inputItem)
        {

            Item? item = _items.Find(item => item.GetName() == inputItem.GetName());
            if (item is null)
            {
                Console.WriteLine($"The {inputItem.GetName()} it dose not exist");
            }
            else
            {
                _items.Remove(inputItem);

                Console.WriteLine($"The {inputItem.GetName()} is DELETED SUCCEFULY!");
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
            if (order == SortOrder.DECS)
            {
                result = _items.OrderBy(item => item.GetDate()).ToList();

            }

            if (order == SortOrder.ASC)
            {
                result = _items.OrderByDescending(item => item.GetDate()).ToList();
            }
            return result;
        }

        public void GroupByDate()
        {
            var groub = _items.GroupBy(item => item.GetDate().Date.Month);
            foreach (var item in groub)
            {
                Console.WriteLine(item);
            }

        }
    }
}
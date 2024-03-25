using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_inventory_management.src
{
    public class Store
    {

        private List<Item> _items = [];
        // public Store(string inputName, int inputQuantity, DateTime inputDate = default) : base(inputName, inputQuantity, inputDate)
        // {
        // }
        public void AddItem(Item inputItem)
        {

            Item? item = _items.Find(item => item.GetName() == inputItem.GetName());
            if (item is null)
            {
                _items.Add(inputItem);
                Console.WriteLine("ADDED SUCCEFULY");

            }
            else
            {
                Console.WriteLine($"The {inputItem.GetName()} is already exist");
            }
            // Any() 
            // Find() 

            // items.ForEach(item =>{
            // if (inputName == item.name){

            //     } 
            // });
        }

        public void GetItems()
        {
            _items.ForEach(item =>
            {
                Console.WriteLine(item.ToString());
            });
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




    }
}
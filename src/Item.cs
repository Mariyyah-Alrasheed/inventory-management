using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_inventory_management.src
{
    public class Item
    {

        private readonly string _name;
        private int _quantity;
        private DateTime _date;

        // when creating Item object, the quantity could not be less than 0 
        // Item banana = new Item("banana", -200)
        public Item(string inputName, int inputQuantity, DateTime? inputDate = null)
        {
            _name = inputName;
            _quantity = inputQuantity < 0 ? throw new ArgumentException("quantity should be bigger than 0") : inputQuantity;
            _date = inputDate is null ? DateTime.Now : (DateTime)inputDate;

        }
        public string GetName()
        {
            return _name;
        }
        public override string ToString()
        {
            return $"name of product : {_name} quantity {_quantity} date {_date}";
        }
        public DateTime GetDate()
        {
            return _date;
        }

        public int GetQuantity()
        {
            return _quantity;
        }
    }
}
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

        // uint Amount = 0;
        public Item(string inputName, int inputQuantity, DateTime? inputDate)
        {
            _name = inputName;
            _quantity = inputQuantity;
            // conditional here, inputDate == default => DateTime.Now or else it will equal to InputDate
            // _date = inputDate == default ? DateTime.Now : inputDate;
            // if the user dont want to put the date, they simply put default , and the computer will take the DateTime.Now
            if (inputDate is null)
            {
                _date = DateTime.Now;
            }
            else
            {
                _date = (DateTime)inputDate;
            }


        }
        public string GetName()
        {
            return _name;
        }
        public override string ToString()
        {
            return $"name of product : {_name} quantity {_quantity} date {_date}";
        }
    }
}
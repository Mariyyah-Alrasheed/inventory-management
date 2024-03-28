namespace sda_onsite_2_inventory_management.src
{
    public class Item
    {
        private readonly string _name;
        private int _quantity;
        private DateTime _date;
        private readonly Guid _id;

        // when creating Item object, the quantity could not be less than 0 
        // Item banana = new Item("banana", -200)
        public Item(string inputName, int inputQuantity, DateTime? inputDate = null)
        {
            _id = Guid.NewGuid();
            _name = inputName;
            Quantity = inputQuantity;
            _date = inputDate is null ? DateTime.Now : (DateTime)inputDate;

        }
        public string GetName()
        {
            return _name;
        }
        public Guid GetId()
        {
            return _id;
        }
        public override string ToString()
        {
            return $"name of product : {_name} quantity {_quantity} date {_date}";
        }
        public DateTime GetDate()
        {
            return _date;
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(" The Quantity is most more than 0 ");
                }
                else
                {
                    _quantity = value;
                }
            }
        }
    }
}
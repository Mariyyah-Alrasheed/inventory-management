// See https://aka.ms/new-console-template for more information

// static void Main(string[] args)
// {
var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
var store = new Store();
store.AddItem(waterBottle);
store.GetItems();






class Item
{
    private readonly string name;
    private int quantity;
    private DateTime date;

    uint Amount = 0;
    public Item(string inputName, int inputQuantity, DateTime inputDate = default)
    {
        name = inputName;
        quantity = inputQuantity;
        // conditional here, inputDate == default => DateTime.Now or else it will equal to InputDate
        date = inputDate == default ? DateTime.Now : inputDate;
        // if the user dont want to put the date, they simply put default , and the computer will take the DateTime.Now


    }
    public string GetName()
    {
        return name;
    }
    public override string ToString()
    {
        return $"name of product : {name} quantity {quantity} date {date}";
    }
}

class Store
{
    private List<Item> items = [];
    // public Store(string inputName, int inputQuantity, DateTime inputDate = default) : base(inputName, inputQuantity, inputDate)
    // {
    // }
    public void AddItem(Item inputItem)
    {

        Item? item = items.Find(item => item.GetName() == inputItem.GetName());
        if (item is null)
        {
            items.Add(inputItem);
            Console.WriteLine("ADDED SUCCEFULY");
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
        items.ForEach(item =>
        {
            Console.WriteLine(item.ToString());
        });
    }


}

/*

var item = new Item(.....)
var item2 = new Item(.....)

var store = new Store()

store.AddItem(item)
*/



// See https://aka.ms/new-console-template for more information

using sda_onsite_2_inventory_management.src;




internal class Program
{
    private static void Main(string[] args)
    {

        //  var banana = new Item("bananae", -10, new DateTime(2023, 1, 1));
        var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
        var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));
        var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
        var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
        var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
        var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
        var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
        var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));
        var toothbrush2 = new Item("Toothbrush2", 50, new DateTime(2023, 10, 1));

        var coffee = new Item("Coffee", 20);
        var sandwich = new Item("Sandwich", 15);
        var batteries = new Item("Batteries", 10);
        var umbrella = new Item("Umbrella", 5);
        var sunscreen = new Item("Sunscreen", 8);

        Console.WriteLine($"===={coffee.GetDate()}");


        var store = new Store(200);
        //  store.AddItem(banana);
        store.AddItem(waterBottle);
        store.AddItem(toothbrush);
        store.AddItem(shampoo);
        store.AddItem(soap);
        store.AddItem(sodaCan);
        store.AddItem(chipsBag);
        store.AddItem(tissuePack);
        store.AddItem(pen);

        store.AddItem(toothbrush2);


        Console.WriteLine($" The total Amount: {store.GetCurrentVolume()}");


        // store.DeletItem(waterBottle2);
        // store.DeletItem(waterBottle2);
        Item foundItem = store.FindItemByName("Water Bottle");
        Console.WriteLine($"{foundItem}");
        store.SortByNameAsc();



        Console.WriteLine("===============DESC==============");
        var sortedByDesc = store.SortByDate(SortOrder.DECS);
        sortedByDesc.ForEach(item => Console.WriteLine($"sortedByDate {item}"));

        Console.WriteLine("==============ASC===============");
        var sortedByAsc = store.SortByDate(SortOrder.ASC);
        sortedByAsc.ForEach(item => Console.WriteLine($"sortedByDate {item}"));




    }


}






// class Item
// {
//     private readonly string name;
//     private int quantity;
//     private DateTime date;

//     uint Amount = 0;
//     public Item(string inputName, int inputQuantity, DateTime inputDate = default)
//     {
//         name = inputName;
//         quantity = inputQuantity;
//         // conditional here, inputDate == default => DateTime.Now or else it will equal to InputDate
//         date = inputDate == default ? DateTime.Now : inputDate;
//         // if the user dont want to put the date, they simply put default , and the computer will take the DateTime.Now


//     }
//     public string GetName()
//     {
//         return name;
//     }
//     public override string ToString()
//     {
//         return $"name of product : {name} quantity {quantity} date {date}";
//     }
// }

// class Store
// {
//     private List<Item> items = [];
//     // public Store(string inputName, int inputQuantity, DateTime inputDate = default) : base(inputName, inputQuantity, inputDate)
//     // {
//     // }
//     public void AddItem(Item inputItem)
//     {

//         Item? item = items.Find(item => item.GetName() == inputItem.GetName());
//         if (item is null)
//         {
//             items.Add(inputItem);
//             Console.WriteLine("ADDED SUCCEFULY");
//         }
//         // Any() 
//         // Find() 

//         // items.ForEach(item =>{
//         // if (inputName == item.name){

//         //     } 
//         // });
//     }

//     public void GetItems()
//     {
//         items.ForEach(item =>
//         {
//             Console.WriteLine(item.ToString());
//         });
//     }


// }

/*

var item = new Item(.....)
var item2 = new Item(.....)

var store = new Store()

store.AddItem(item)
*/



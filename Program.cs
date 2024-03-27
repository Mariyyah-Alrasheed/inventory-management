// See https://aka.ms/new-console-template for more information

using sda_onsite_2_inventory_management.src;




internal class Program
{
    private static void Main(string[] args)
    {
        var waterBottle = new Item("Water Bottle", 10, new DateTime(2024, 1, 1));
        var pen = new Item("Pen", 20, new DateTime(2024, 2, 1));
        var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
        var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
        var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
        var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
        var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
        var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));

        var coffee = new Item("Coffee", 20);
        var sandwich = new Item("Sandwich", 15);
        var batteries = new Item("Batteries", 10);
        var umbrella = new Item("Umbrella", 5);
        var sunscreen = new Item("Sunscreen", 8);

        Console.WriteLine($"===={coffee.GetDate()}");

        var store = new Store("AL-TIMIMY", 2000);
        store.AddItem(waterBottle);
        store.AddItem(toothbrush);
        store.AddItem(shampoo);
        store.AddItem(soap);
        store.AddItem(sodaCan);
        store.AddItem(chipsBag);
        store.AddItem(tissuePack);
        store.AddItem(pen);
        store.AddItem(sunscreen);
        store.AddItem(sandwich);
        store.AddItem(batteries);
        store.AddItem(umbrella);
        store.AddItem(coffee);


        Console.WriteLine($" The total Amount: {store.GetCurrentVolume()}");


        Item foundItem = store.FindItemByName("Water Bottle");
        Console.WriteLine($"{foundItem}");
        store.SortByNameAsc();


        Console.WriteLine("===============DESC==============");
        var sortedByDesc = store.SortByDate(SortOrder.DECS);
        sortedByDesc.ForEach(item => Console.WriteLine($"sortedByDate {item}"));

        Console.WriteLine("==============ASC===============");
        var sortedByAsc = store.SortByDate(SortOrder.ASC);
        sortedByAsc.ForEach(item => Console.WriteLine($"sortedByDate {item}"));

        Console.WriteLine("===================================");

        store.GroupByDate();
        store.DeleteItem("Toothbrush");
    }


}


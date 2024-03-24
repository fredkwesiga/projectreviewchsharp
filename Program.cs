// Perform operations on arrays using helper methods in C#

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");
//Array.Sort(pallets);
//Array.Reverse(pallets);
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
//split and join
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

string pangram = "The quick brown fox";
char[] pangram1 = pangram.ToCharArray();
Array.Reverse(pangram1);
string result1 = new string(pangram1);
Console.WriteLine(result1);

////////
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(",");
Array.Sort(items);

foreach( var item in items)
{
    if(item.Length == 4){
        Console.WriteLine(item);
    }
    else {
        Console.WriteLine(item + "\t- Error");
    }
}




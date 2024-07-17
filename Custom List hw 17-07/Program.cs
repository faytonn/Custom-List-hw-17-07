using Custom_List_hw_17_07;

CustomList<int> list = new CustomList<int>();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);
list.Add(7);

Console.WriteLine("Here is the list: ");
foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nTask: finding element 3");
Console.WriteLine(list.Find(3));

Console.WriteLine("\nTask: Finding all elements");
CustomList<int> foundElements = list.FindAll(x => true);
foreach(var element in foundElements)
{
    Console.WriteLine(element);
}

Console.WriteLine("\nTask: Removing element 5");
list.Remove(5);
Console.WriteLine("result:");
foreach (var element in list)
{
    Console.WriteLine(element);
}

Console.WriteLine("\nTask: Removing all elements");
list.RemoveAll(x => true);
Console.WriteLine("result: ");
foreach (var element in list)
{
    Console.WriteLine(element);
}

List<int> smth = new List<int>();
smth.Add(1);
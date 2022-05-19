// See https://aka.ms/new-console-template for more information
using BusinessData.ofWarehouse.Model;

Warehouse Warehouse = new();
var properties = typeof(Warehouse).GetProperties();
foreach(var prop in properties)
{
    Console.WriteLine(prop.PropertyType);
    if(prop.PropertyType.IsGenericType)
    {
        Console.WriteLine("맞습니다.");
    }
}


// See https://aka.ms/new-console-template for more information
using BusinessData.ofWarehouse.Model;
using BusinessView.ofUser;

Console.WriteLine("Hello, World!");
Warehouser Warehouser = new();
var ResponseMessage = await Warehouser.CreateWarehouse();
if(ResponseMessage.IsSuccessStatusCode)
{
    Console.WriteLine(ResponseMessage.Content.ToString());
    Console.WriteLine("Success");
}
else
{
    Console.WriteLine("Fail");
}

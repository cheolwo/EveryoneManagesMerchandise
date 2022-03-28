// See https://aka.ms/new-console-template for more information
using BusinessView.ofTest;
using Newtonsoft.Json;
using PlanLogisticsUserWebApp.Data;

Console.WriteLine("Hello, World!");
V_Test V_Test = new V_Test();
var Message =  await V_Test.WeatherforecastGet();
foreach(var item in Message)
{
    Console.WriteLine(item.Summary);
}

var Message3 = await V_Test.ListWeatherforecastGet();
foreach(var item in Message3)
{
    Console.WriteLine(item.Summary);
}


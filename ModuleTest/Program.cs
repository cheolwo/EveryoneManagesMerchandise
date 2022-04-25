// See https://aka.ms/new-console-template for more information
using BusinessData.ofWarehouse.Model;
using BusinessView.ofGeneric;
using BusinessView.ofUser;
using BusinessView.ofWarehouse.ofEmployer;
using TestProject;

List<WCommodity> wCommodities = new List<WCommodity>();
wCommodities.Add(new WCommodity { Name = "First"});
wCommodities.Add(new WCommodity { Name = "Second" });
wCommodities.Add(new WCommodity { Name = "Third" });

Warehouse warehouse = new();
warehouse.Name = "asdfasdf";
warehouse.Address = "aadshdsfhhhhhhh";
warehouse.WCommodities = wCommodities;

EmployerWarehouse EmployerWarehouse = new();

ModelToDTO<Warehouse, EmployerWarehouse>.ConvertToDTO(warehouse, EmployerWarehouse);
Console.WriteLine(EmployerWarehouse.Name);
Console.WriteLine(EmployerWarehouse.Address);
Console.WriteLine(EmployerWarehouse.WCommodities);

Warehouse ModelWarehouse = new();

DTOToModel<EmployerWarehouse, Warehouse>.ConvertToModel(EmployerWarehouse, ModelWarehouse);
Console.WriteLine(ModelWarehouse.Name);
Console.WriteLine(ModelWarehouse.Address);
foreach (var w in ModelWarehouse.WCommodities)
{
    Console.WriteLine(w.Name);
}

UnitTest1 unitTest1 = new UnitTest1();
unitTest1.TestMethod1();

UserActor userActor = new UserActor(new ActorOption { IsUseStorage = false});
LogisterActor LogisterActor = new LogisterActor(new ActorOption { IsUseStorage = false });



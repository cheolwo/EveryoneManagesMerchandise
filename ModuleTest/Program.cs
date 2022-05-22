// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using BusinessLogic.ofExternal.ofSearchingService;

JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
jsonSerializerOptions.WriteIndented = true;

//Warehouse warehouse = new();
//warehouse.CenterIPAddresses.Add(new CenterIPAddress { Id = 123 });
//warehouse.ImageofInfos.Add(new ImageofInfo { Id = 123 });
//warehouse.WCommodities.Add(new WCommodity { Id = "asdf" });

//EmployerWarehouse employerWarehouse = new();
//employerWarehouse = ModelToDTO<Warehouse, EmployerWarehouse>.ConvertToDTO(warehouse, employerWarehouse);
//Console.WriteLine(employerWarehouse.ImageofInfos);
//Console.WriteLine(employerWarehouse.WCommodities);
//Console.WriteLine(employerWarehouse.CenterIPAddresses);

//Warehouse newWarehouse = DTOToModel<EmployerWarehouse, Warehouse>.ConvertToModel(employerWarehouse, new());
//Console.WriteLine(newWarehouse.ImageofInfos[0].Id);
//Console.WriteLine(newWarehouse.CenterIPAddresses[0].Id);
//Console.WriteLine(newWarehouse.WCommodities[0].Id);



KoreaSearchingAddressService KoreaSearchingAddressService = new();
var addresses = await KoreaSearchingAddressService.GetKoreadAddressByKeyword("아차산로");
foreach(var addr in addresses)
{
    Console.WriteLine(addr);
}


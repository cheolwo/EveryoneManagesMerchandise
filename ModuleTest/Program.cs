// See https://aka.ms/new-console-template for more information
using BusinessData.ofWarehouse.Model;
using BusinessData;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using System.Text.Json;
using BusinessView.ofGeneric;

JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
jsonSerializerOptions.WriteIndented = true;
Warehouse warehouse = new();
warehouse.CenterIPAddresses.Add(new CenterIPAddress { Id = 123 });
warehouse.ImageofInfos.Add(new ImageofInfo { Id = 123 });
warehouse.WCommodities.Add(new WCommodity { Id = "asdf" });
EmployerWarehouse employerWarehouse = new();
employerWarehouse = ModelToDTO<Warehouse, EmployerWarehouse>.ConvertToDTO(warehouse, employerWarehouse);
Console.WriteLine(employerWarehouse.ImageofInfos);
Console.WriteLine(employerWarehouse.WCommodities);
Console.WriteLine(employerWarehouse.CenterIPAddresses);

Warehouse newWarehouse = DTOToModel<EmployerWarehouse, Warehouse>.ConvertToModel(employerWarehouse, new());
Console.WriteLine(newWarehouse.ImageofInfos);